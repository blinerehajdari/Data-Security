     
**Detyra e dyte** -- **Vigenere Cipher**
     * Vigenere Cipher duke gjeneruar celes nga keystream duke perdorur nje int32 ose string si seed.
     
**Detyra e trete** -- **Base64**

Në këtë projekt është realizuar Enkodimi - Dekodimi me bazë 64 për lëndën Siguria e të dhënave, të ligjëruar nga
profesori Blerim Rexha dhe asistenti Mërgim Hoti. Kodi është shkruar në gjuhën programuese C# dhe ekzekutuar në 
Visual Studio. Fajlli final përfshinë tri pjesë, në dy prej të cilave janë krijuar DLL fajllet dhe fajlli i tretë që përmban 
Window Application. Për krijimin e këtyre fajlleve është përdorur lloji 'Class Library' të ofruar nga Visual Studio.
Libraritë tona Encryption dhe Decryption, përveç funksionit kryesorë që kanë për konvertim, ato përmbajnë edhe disa
metoda tjera që mund të hyjnë në dobi.

Encryption:

       ► char convertIntToChar (int number) - gjen karakterin përkatës për numrin me bazë 64, indeksi i të cilit është 'number'.
       ► string convertIntToBinary (int number) - kthen një numër të vetëm në binarë.
       ► string convertTextToBinary (string text) - kthen një tekst në numra binarë 8 bitësh.
       ► string splitBySixBits (string text) [text - teksti binarë i marrur nga funksioni 'convertTextToBinary']
       ► string addPaddingToText (string text) - shton barazimet tek teksti nëse modul 4 nuk është zero.
       ► string Encode (string text) - metoda finale që kombinon metodat e mësipërme.
Decryption:

       ► int convertCharToInt (char character) - konverton një karakter në numër përkatës me bazë 64.
       ► string convertIntToBinary (int number) - kthen një numër të vetëm në binarë.
       ► string convertTextToBinary (string text) - kthen një tekst në numra binarë 6 bitësh.
       ► string splitBySixBits (string text) [text - teksti binarë i marrur nga funksioni 'convertTextToBinary']
       ► string Decode (string text) - metoda finale që kombinon metodat e mësipërme.
       ► string isStringValid (string text) - kontrollon a është valid teksti për dekriptim.
Më pas, kemi integruar këto librari në Graphical User Interface gjithashtu të krijuar në C#. GUI ofron këto opsione:

       ► Enkodimin me anë të shkresës.
       ► Enkodimin me anë të importimeve.
       ► Dekodimin me anë të shkresës.
       ► Dekodimin me anë të importimeve.
       ► Eksportimin e tekstit final.
       ► Validimin se a mund të Dekodohet një tekst.
       
      
      FIEK @2022, Siguria e të dhënave
