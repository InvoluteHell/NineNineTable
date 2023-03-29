.386
.model flat, stdcall
.stack 4096

INCLUDELIB ucrt.lib
INCLUDELIB legacy_stdio_definitions.lib

printf PROTO C : DWORD,:vararg

.data
	fmt DB '%d*%d=%d',09H, 00H
	line DB 0aH, 00H

.code
main PROC
	push ebx
	push esi
	push edi
	mov  esi, 1
L1:
	mov  edi, 1
	cmp  esi, edi
	jl   L3
	mov  ebx, esi
L2:
	push ebx
	push edi
	push esi
	push OFFSET fmt
	call printf
	inc  edi
	add  esp, 16
	add  ebx, esi
	cmp  edi, esi
	jle  L2
L3:
	push OFFSET line
	call printf
	inc  esi
	add  esp, 4
	cmp  esi, 9
	jle  L1
	pop  edi
	pop  esi
	xor  eax, eax
	pop  ebx
	ret  0
main ENDP
END main