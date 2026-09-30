#include <iostream>
#include <string>
using namespace std;

static char checkGender(string PESEL) {
	if (PESEL[9] % 2 == 0) {
		return 'K';
	}
	else {
		return 'M';
	}
}


/*
***********************************************
nazwa funkcji: checkSum
opis funkcji: Sprawdza sume kontrolną PESELA
parametry: PESEL - podawany pesel
zwracany typ i opis: typ logiczny, sprawdza czy suma kongtrolna się zgadza
autor: skibidisigma😂
***********************************************
*/
static bool checkSum(string PESEL) {
	int S = 0, M, R;
	int weights[] = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

	for (int i = 0; i < 10; i++) {
		S += (PESEL[i] - '0') * weights[i];
	}

	M = S % 10;
	if (M == 0) {
		R = 0;
	}
	else {
		R = 10 - M;
	}

	return (PESEL[10] - '0') == R;
}

int main() {
	string PESEL = "55030101193";
	cout << "Podaj PESEL: " << endl;
	cin >> PESEL;
	string gender = "";
	string isPeselRight = "";

	if (checkGender(PESEL) == 'K') {
		gender = "Kobieta";
	}
	else {
		gender = "Mężczyzna";
	}

	if (checkSum(PESEL)) {
		isPeselRight = "Pesel JEST poprawny";
	}
	else {
		isPeselRight = "Pesel NIE JEST poprawny";
	}

	cout << "Płeć: " << gender << endl;
	cout << "Poprawność: " << isPeselRight << endl;
}

