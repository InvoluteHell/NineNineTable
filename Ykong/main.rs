fn main() {
    (1..=9).for_each(|i|{(1..=i).for_each(|j|print!("{}x{}={}\t",j,i,i*j));println!()});
}
