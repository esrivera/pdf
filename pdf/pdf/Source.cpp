#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <iostream>
#include <string>
#include "Librerias.h"
#include "Header.h"
#include <fstream>
int  AyudaF1();

int main() {
	int nume;
	printf("Ingrese numero:");
	scanf("%d", &nume);
	ofstream fs("Datos.txt");

	fs << "************************NUMERO PDF*************" << endl;
	fs << "Su numero es: " << nume << endl;
	fs.close();
	
	/***********************************/

int imp;
system("cls");
imp = AyudaF1();
if (imp == 1)
{
	ofstream LeerDatos;
	LeerDatos.open("Datos.txt", ios::out | ios::app);
	tifstream in(TEXT("Datos.txt"));
	PrintFile(in);
	ShellExecute(NULL, TEXT("open"), TEXT("D:\\Programacion 1\\C++\\Proyecto\\PDF QR\\pdf\\Datos.pdf"), NULL, NULL, SW_SHOWNORMAL);
}
system("pause");
_getch();
}

int  AyudaF1() {
	int x;
	int imp;
	printf("\nPresione Enter ");
	for (;; ) {
		x = _getch();//captura la tecla de función ,pertenece a la libreria conio.h
		if (x == 13)
		{
			imp = 1;
			printf("\nGenerando...");
			break;
		}
	}
	return imp;
}
