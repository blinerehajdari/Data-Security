#include <iostream>

using namespace std;

string mesazhi;
string mappedKey;
void mesazhidheqls(){
    string msg;
    //qls-qelesi
    //msg-mesazhi
    //qlsMap-keyMap
    cout << "Shenoni mesazhin: ";
    getline(cin, msg);
    cin.ignore();
    for(int i = 0; i < msg.length(); i++){
        msg[i] = toupper(msg[i]);
    }
    string qls;
    cout << "Shenoni qelesin: ";
    getline(cin, qls);
    cin.ignore();
    for(int i = 0; i < qls.length(); i++){
        qls[i] = toupper(qls[i]);
    }
    string qlsMap = "";
    for (int i = 0,j = 0; i <msg.length();i++){
        if(msg[i] ==32){
            qlsMap += 32;
        } else {
            if(j<qls.length()){
                qlsMap += qls[j];
                j++;
            } else {
                j = 0;
                qlsMap += qls[j];
                j++;
            }
        }
    } 
    mesazhi = msg;
    mappedKey = qlsMap;
}

int tableArr[26][26];
void createVigenereTable() {
	for (int i = 0; i < 26; i++) {
		for (int j = 0; j < 26; j++) {
			int temp;
			if ((i + 65) + j > 90) {
				temp = ((i + 65) + j) - 26;
				tableArr[i][j] = temp;
			}
			else {
				temp = (i + 65) + j;
				tableArr[i][j] = temp;
			}
		}
	}
}

void cipherEncryption(string mesazhi, string mappedKey) {
	createVigenereTable();
	string encryptedText = "";
	for (int i = 0; i < mesazhi.length(); i++) {
		if (mesazhi[i] == 32 && mappedKey[i] == 32) {
			encryptedText += " ";
		}
		else {
			int x = (int)mesazhi[i] - 65;
			int y = (int)mappedKey[i] - 65;
			encryptedText += (char)tableArr[x][y];
		}
	}
	cout << "Teksti i encryptuar: " << encryptedText;
}

int itrCount(int qls, int msg){
    int counter = 0;
    string resultati = "";
    for(int i = 0; i < 26; i++){
        if(qls+i > 90){
            resultati += (char)(qls+(i-26));
        } else {
            resultati += (char)(qls+i);
        }
    } 

    for(int i = 0; i < resultati.length(); i++){
        if(resultati[i] == msg){
            break;
        } else {
            counter++;
        }
    }
    return counter;
}


void cipherDecryption(string mesazhi, string mappedKey){
    string decryptedText = "";
    for(int i = 0; i < mesazhi.length(); i++){
        if(mesazhi[i] == 32 && mappedKey[i] == 32){
            decryptedText += " ";
        } else {
            int temp = itrCount((int)mappedKey[i], (int)mesazhi[i]);
            decryptedText += (char)(65+temp);
        }
    }

    cout << "Teksti i decryptuar : " << decryptedText;
}

int main(){
    cout << "Mesazhi dhe zgjedhja mund te jene vetem shkronja alfabetike" <<endl;
    int zgjedhja=0;
    cout << "1. Encryption\n2. Decryption\n Zgjedh(1,2): ";
    cin >> zgjedhja;
    cin.ignore();
    if (zgjedhja == 1){
    cout << "Encryption" << endl;
    mesazhidheqls();
    cipherEncryption(mesazhi, mappedKey);
    } 
    else if (zgjedhja == 2){
    cout << "Decryption" << endl;
    mesazhidheqls();
    cipherDecryption(mesazhi, mappedKey);
    } 
    else {
    cout << "Zgjedhja e gabuar" << endl;
    }
    return 0;
}