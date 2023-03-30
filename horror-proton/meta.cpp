#include <cstdio>
#include <type_traits>
#include <utility>
template <char... C> using fixed_string = std::integer_sequence<char, C...>;
template <typename... Ts> struct cat_fs;
template <typename... Ts> using cat_fs_t = typename cat_fs<Ts...>::type;
template <typename First, typename... Rest>
struct cat_fs<First, Rest...> : cat_fs<First, cat_fs_t<Rest...>> {};
template <char... C, char... D>
struct cat_fs<fixed_string<C...>, fixed_string<D...>>
    : std::type_identity<fixed_string<C..., D...>> {};
template <typename T> struct fs_to_str;
template <char... C> struct fs_to_str<fixed_string<C...>> {
  static constexpr char value[sizeof...(C) + 1] = {C..., '\0'};
};
template <typename T> static constexpr auto fs_to_str_v = fs_to_str<T>::value;
template <size_t I, typename Enabled = void>
struct int_to_fs : std::type_identity<fixed_string<'0' + I>> {};
template <size_t I> using int_to_fs_t = typename int_to_fs<I>::type;
template <size_t I>
struct int_to_fs<I, std::enable_if_t<(I >= 10)>>
    : cat_fs<int_to_fs_t<I / 10>, int_to_fs_t<I % 10>> {};
template <size_t L, size_t R>
using gen_expr_t = std::conditional_t<
    (L >= R),
    cat_fs_t<int_to_fs_t<L>, fixed_string<'*'>, int_to_fs_t<R>,
             fixed_string<'='>, int_to_fs_t<L * R>>,
    fixed_string<>>;
template <size_t R, size_t... C>
using temp = cat_fs_t<cat_fs_t<gen_expr_t<R, C>, fixed_string<'\t'>>...>;
template <typename Seq1, typename Seq2> struct table;
template <size_t... Dim1, size_t... Dim2>
struct table<std::index_sequence<Dim1...>, std::index_sequence<Dim2...>>
    : std::type_identity<
          cat_fs_t<cat_fs_t<temp<Dim1, Dim2...>, fixed_string<'\n'>>...>> {};
int main() {
  using seq = std::index_sequence<1, 2, 3, 4, 5, 6, 7, 8, 9>;
  std::printf("%s", fs_to_str_v<table<seq, seq>::type>);
}
