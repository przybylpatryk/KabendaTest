#include <iostream>
#include <fstream> 
#include <string>
#include <cmath>
using namespace std;

int main() {
	string krotka;
	int suma1 = 0, suma2 = 0;

	// komentarz jednoliniowy
	ifstream File("C:\\Users\\student\\Desktop\\Dane-NF-2605\\pary_przyklad.txt"); // sciezka do pliku

	/*
	* komentarz wieloliniowy
	*/

	while (getline(File, krotka)) {
		for (int i = 0; i < krotka.length(); i++) {
			if (!krotka[i] == ' ') {
				suma1 += krotka[i];
			}
			else {
				suma2 = suma1;
				suma1 = 0;
			}
		}
	}
}