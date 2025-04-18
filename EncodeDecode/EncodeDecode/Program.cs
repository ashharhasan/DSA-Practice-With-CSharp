String EncodedString = Encode(new List<string>{"|neet|neet|neet|neet","code|code|","love","you"});

Console.WriteLine(EncodedString);

List<String> output = Decode(EncodedString);

foreach(var str in output){
    Console.Write(str+",");
}

string Encode(IList<string> strs) {
        string output="";
        foreach(string str in strs)
        {
            output += str.Length +"|"+ str;
        }
        return output;
    }

 List<string> Decode(string s) {

    bool PickMode=false;
        int pick=0;
        string tempStr="";
        List<string> output = new List<string>();

        foreach (var chr in s)
        {
            if(PickMode)
            {
                tempStr+=chr;
                if(pick==1)
                {
                    PickMode =false;
                    output.Add(tempStr);
                    tempStr="";
                    
                }
                pick--;

            }
            else{
                if(chr == '|')
                {
                    PickMode=true;
                    if(tempStr!="")
                        pick=int.Parse(tempStr);
                    tempStr="";
                }
                else
                {
                    tempStr +=chr;
                }
                
            }
        }
        return output;
   }