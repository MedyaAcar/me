#include <iostream>
#include<string>
using namespace std;

int main()
{
    char metin[1000];

       //1000 karakter alabilecek bir char array'i tanimlanmasi

    cout << "gercek metni girin: ";
    cin >> metin;       //metin input'unun alinmasi
        for(int i=0; i<1000; i++){  //metindeki tüm karakterlerin
            if(metin[i]!=char(0)){  //input sonuna kadar isleme sokulmasi
                if(i%2==0){
                    metin[i]+=1;
                } else {
                    metin[i]-=1;
                }
            } else {                //input sonunda islemin durdurulmasi
                i=1000;
            }
        }
    cout << "" << metin; //sifrelenmis metnin yazdirilmasi
    cout << "" << endl;
    return 0;
}
