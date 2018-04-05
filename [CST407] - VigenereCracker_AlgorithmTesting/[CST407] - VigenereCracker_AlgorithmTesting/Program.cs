using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//<---added
using System.Text;//<---added
using System.Resources;

namespace _CST407____VigenereCracker_AlgorithmTesting
{
    //_________________________________________________________________________________________________
    //CHARLES BABBAGES METHOD:
    //      FIND KEY LENGTH
    //      BREAK TEXT INTO KEY LENGTH SETS
    //      LETTER FREQUENCY ANALYSIS OF CEASAR GROUPS
    //      CRACKING VIGENERE BY UNWINDING WITH PROBABLE KEY
    //_________________________________________________________________________________________________
    class Program
    {
        //member variables
        static string mCipher = "UBPTKWVEFYGLYGMEKYTXIGUSXRKZIEVRMJUALZYLNRRWKVNXYWIPUSYFIISEDCVYINKGXWJASPSYMSFHSWGVVYIYALHXKAQGGVXKCSIELHKVQKWWDKEADGUXASNILVNGRFWXVUCMDEIFZEMWNWVVSXVFXAWAKRGJIUVRVWCCXYWZKVXGSGTWVUSWEXKQMXHVLLGXVHOCCKJWRUVSYMLVIEUCYRWKWCCJFJGGUSGLBTEDWVKTEGKCSISQXJVRHNYBFVJINVGMAICSWBSJEJDWHCIUQAJFWXGJESEWRVIMVZUGHEABQELTVURGLKIFYMFGZQIZFKUFJMGHRSDEYPZWFDIDOZFKHFVTFUGIESMPNLBUBISVKXCSPBKBWMJSRVZGHEGJRZKXEIIWWHIMRDWMVRGWXNWVDIEKIWLBTTFKXEFPHFCPPESXKFRLSMILVFIYTSEVQPVSSXVCIZJIJRUKSXZIMDYPHVJRKBMMSEWVLKLEYIOKYTQVVXQRGVWJIXYWGJRPEWHVIZFEOZPBLUCXJHIGTLBFDPRLSVAZRPZCRLYWTNVHZWXHYGHSTKJHJMDGRDPGUATJMDJESXKFRTDFXFVJEVZSGCYCRVVCERQXAHISFXJKTIPANWXYWZKVAMZUIPRGWDFVWWLXRXGRDFXAFIGXYSRFJSNLBKMVLRCDEGVICGYARCSYKEUILRAPCEHTFXREDTSFZETKQTPCOEUKLXDCCGYHMPFJNKLTWZKXCEGXLIRSDEYPZWFAHHSLLLGRWMSMXESMXVYINFZPZFJEDCIIJIHTVUXUWSKLBTYJWSHRQXJCREEYVQLRWXIGGVKXJVVXHLDQGLIFYMFLIRSDHVQDMLWQXXYLLGJSOAYIWIWMPJXTDFXRXLLGEINLLPPZKXUFYOSHCEGZSWDETKJGMDWQKEMLLYGEEVTTVTTJCCKKGRGXSMAUIIRUICJIYALTFVLAGVRZGPTVEEIPKEGVWDQDMRKJXYGLRIJLLKJGHEJGSDAWGWSEDILIUTCVYIYSCAYIWSHKLXTUNSWHMIJMGNUHMFFSHTYUSCCEGJMNIMLCYSTIGZQBMGYHTAIWTWSPBUUCGYSVIVWHXUUEZDYTVSYWZUITLMXVEGLCRSDEYPZWMJYHSCNICKXAWMPQVLMOVMGKOGKVFXIRMGKCCWFMXJMMXLHPQYSHGIELWXILVGTVZQBKGDJKZINRXXKUCHKZIFZIFJYVMDWWWUHXFFNPFGOGUZNDHTVRTPGZRMZYHITAVELQLLUCGVKXJVEWECCMJLVCKMHFWWSJWZKVXGSGPWKZIHFGNKIUMKKVGJMLLUCGVLSEFQFMHXWKWBRRRLAICMESWKRXAWJDTLDEVZSGVCHXIAFWKMHFCCWFMXJMMXLHPQIWJNVGMWXILVUSWEXKQMISGGKTRTAQNWIEGRXZIMFUBIJWXTZFTDAGSLHWVYEMHLTHFEMPRXXVCCXYWLKXLESHSWIWTTVWXFNTHRKQCCPYJURXZGRQWXAWMDYKZZKVXGSGTWVHSRLPTLCDRMAIVEEFVYRPRKWKWMXVXTWGAXGKLXVUBEXWXQKLXSATRTQWTVTNLUIMFFMPWPBUNTHSQXJVFTQIUTZYWFZWTKNTVGJIUZHXFNZIEFIFPELKCVRVVGKRELAACMWAGCEXLZUGIFXXJVIQHUCHVVIHWSKLCCZZWXPRQBFHPXZGRCCWXUOGMKQEEKMHFGTQFJEPUYFFMPQFXQCPLXSOILFJMBVHTHLDKISQHFVVGPTVKSGVZSGKNDFVUETIMXVIJXSQXJVGXFNGECARVVPEAATRTWEIVRVQQWMTZAQLPWHLTGVVICEHKWGPMEARHFVVWUUXVJEPPGHEGXXDWRVFJNKZDVTWWVFWHMNWZZWXPRQTKIUJZUMCCWBFQPWYARIKSGSHSWRAKQEAHJETHKGEEHYBJYPRUVIRCSRFYLVVKSWIGXKZDVKZIEFYGLYGMEKYTXIGUSTJWGVVZROAYIRREXJVKOFJDWZLMQEGHFNXRLWHVFHXLYGMFJEVVMGGWISSWVVYIIJYHMUWRVJIGLBXWGWVUFRTDGXPZLETPVXHLTWVFXCKMOWATRVJENDEQOYAPKSCNFVTFXLLZLIJFYLWUSZZKITFROAYIRREACCXPJIHXFOXQJEBYICJFJEHZVLLBPRUSWUVWLEYCXKZIAIIMMLCIUOMVYVXUIBQVFHCKMHFMUSISQCJWBNYCINUSODMMEYCXZFGNLHBFAIVFGTUBIGFYSCSSGMVHTOUNJIGQFVTEGSXRXYVQLRWXIGGVKFWKEIHLDZVVEFUMMAICECEEVVVBSFPRUSHXZWHJSHYGHSTKMGLBXWTDMORXXVWXECDIPUYEDYHELLLQIMSWXILVXMTJXFSDDVTAEEFYGLYGMEKYTXIGUSEVFYVCDWBFWTXYWWKXRBFADJEKEOFRHUNDFVJLGVRWGLHIUSWCZKHFMIEKASPGVHHIHECLSNRYGUBPZZDPCXIWWZTRJWTTFKKSGXRKZINZKALFNTFHYNRXXVVJXJLVCKIZAWPPCQMOGSKLUCXTWRVIEEZCVLCSRFJXAWWXEJUSWEXXJCCWLJKGEGRJIAIXJIYRJMWLPRZFXGIEZWHRCKSWMWSKUYCSKWHKENTFOPVPLLCKWNHJDVKLSKIVXYOAEIXSTDEMAICWWWPNLRWWLILVBYTZWWAWIMFFSHEIBLBTVKZIOREZFIGXYWGKMMEAUCEZVQKJWBGHRECDIFKLXMMDTVJEVZSGKGXWJASPLWHENWIKSWMWSKUYGITGQOVRWWXXRJLICUXASNRMRTIEYEKYYSAZLLVYMLJYHTFFWKSMEANNMEEEAUIYWHHIJWGTVXTJSBGESQCIEPWHIJLJXJVVIJIBMJARIWEKWUHXUAZKJMHFWWMVXHGJQHFXUMKRKGIEEVUQPRFOEYIVCCCXVJQUFJFWHBSEWCCEHFSNTVZWPFLVBFAPPCLLGUMLUOHWZGRCSSNLHTAJLVCKIZAYHYEVITKLXUIJRKWVKEWNJATRTQVWSVBUNWILKVGJTHFMTXFUSODYGAMIEUNEPTILAHHSLLLXZIMFUBGFFXKEYXVNDIDHLCJMSWUBMCAXCICUMCAHLHXJVMGXFJBFXQKCMMSLNLRJHYRVXSHSEUNMUVVLSHSIJHIEZEEDSILVARVISWMWIMFFSHKLXZYAMTGTVVVUGLCIZFJCEXKQUIXRUOTVKTAHTHKZIOZPBLUGCZXRQKXAWJDPZLMERPBFCIMRLMXVJHJNWIXNRWEXBDNWIMAIVTSGYUSEGLIFKLXALIETLMEJEGVBJQZDMCKIWSMJTVJMQIEKNHUSIUICKXAWXTPKSLCDPXLIUEGTEEZRCSHJEIQHWIMGYNWMJHITZSWXLDQVSVNPYGLCAGZNMNLRKWMITRJENPDXVNWIUAIOIIZAGTMEEMFTMTAHCSMSXKFRLDYSXYWEOVVBUUCWZVIQWXAWXJECWJHFVMLILIRCIPKLXNCTXTGRIJVNJUASIYEPZDTLCDRRFHVFQHTCAMQWXJVTXSMPRKJCVFHXXYCHZLWGCJUQFPXVLLGGVHYLPQJZEFVBISHSIUTIAFRWLBTEXWREPWVSJPGZLCVFEWECCMJLITKLXEUCHFNITKLXUIJVJWSHKLXKNPXZGREVHXVCIWDSRCXIFWHIXFLLGDEVNNWMJWBGIGBKYRECDIFFTXJUIMFFWYZXVZVPGBWRFVHHFHDZVEFGIXAWMPQVVEAFRPZCRLUAWUZHXFNVIEWVCCWXFWDYISKGUFRLBTOVFRGUC";//<---stores cipher message :NOTE: Can be changed here and will be text input in windows form app:"GENERALPHONGISREADYTHEKINGISINPLAYALLTHEPIECESMOVEATMIDNIGHTTHETARGETISLORDVADER"
        static string mAlphabet = "abcdefghijklmnopqrstuvwxyz";//<---used as an easier way to set key values, leaving the frequency file with only the corresponding double values: makes iteration and key value pair assignments easier :USEDIN: FillFreqDict()
        static string mFilePath = @"C:\Users\Jered\source\CST407\[CST407] - VigenereCracker_AlgorithmTesting\[CST407] - VigenereCracker_AlgorithmTesting\Resources\FreqDict.txt";//<---file path to letter frequency file  
        static int mProbKeyLength = 0;//<---stores probable key length during string testing: initial value set to 0 :USEDIN: FindKeyLength(), CipherToKeyLenSets(), LetterFreqAnalysis()
        static Dictionary<char,double> mFrequency = new Dictionary<char, double>();//<---stores (key char)alphabet a-z: stores (value double)occurance probabilities :NOTE: Based on letter probabilities in the english language
        static List<string> mKeyLenSets = new List<string>();//<---stores sets of strings of key length = mProbKeyLength :RTRNBY: CipherToKeyLenSets()
        static List<string> mDiGraphList = new List<string>();//<---holds all 2 letter pattern repeats from cipher text: NOTE: Di graphs may not be very useful
        static List<string> mTriGraphList = new List<string>();//<---holds all 3 letter pattern repeats from cipher text
        static List<string> mQuadGraphList = new List<string>();//<---holds all 4 letter pattern repeats from cipher text
        
        //FUNCTIONS================================================================================
        /*
        //  FUNC:   FillFreqDict(string arg)
        //  TASK:   Populates dictionary with alphabet letters and their corresponding frequency percentage values based on the english language
        //  ARGS:   Takes a string file path: loads the file based on path: parses through it filling the dictionary
        //  RTRN:   Dictionary
        */
        public static Dictionary<char,double> FillFreqDict(string filePath)
        {
            //local variables
            filePath = mFilePath;//<---set file path
            string line = String.Empty;//<---hold stream line for line by iteration
            Dictionary<char,double> tempDict = new Dictionary<char, double>();//<---gets filled by file stream iterator: is return variable
            char key;
            double value;

            //iterate through file stream
            using (StreamReader reader = File.OpenText(filePath)/*File.OpenText(filePath)*/)
            {
                //local variables
                int ndx = 0;//<---indexer for mAlphabet

                //fill dictionary with key value pairs
                while((line = reader.ReadLine()) != null)
                {
                    //set key value pairs
                    key = mAlphabet.ElementAt(ndx);//<---uses mAlphabet iteration to set keys
                    value = double.Parse(line);//<---uses file stream itrerator line variable to set values

                    //add key value pairs to dictionary
                    tempDict.Add(key, value);

                    //increment ndx
                    ndx++;
                }
            }

            //return temporary dictionary
            return tempDict;
        }
        /*
        //  FUNC:   GraphBuilder(int arg)
        //  TASK:   Builds graphs(di, tri, quad) based on passed in argument
        //  ARGS:   String cipher text
        //  RTRN:   List
        */
        public static List<string> GraphBuilder(int nGraph)
        {
            //local variables
            List<string> graphList = new List<string>();//<---stores all the nGraph strings: Is return variable
            string cipher = mCipher;//<---set cipher text: initialize to member variable mCipher
            string graph = String.Empty;//<---hold current iteration of graph string: initialize to empty string
            int cipherStringNdx = 0;//<---cipher text iterator index: initialize to 0
            int cipherLength = cipher.Length;//<---used for while loop control iterating through entire cipher text string: initialized to cipher string length
            char currentCharacter;//<---stores current character iteration being looked at
            
            //iterate through cipher text: TODO: MUST BE TWEAKED TO NOT ACCEPT NONE CHARACTERS
            while (cipherStringNdx < (cipherLength - 1))
            {
                //build graph(n character strings)
                for (int GraphNdx = 0; GraphNdx < nGraph;/**/)
                {
                    //set current = next character iteration from cipher text string
                    currentCharacter = cipher.ElementAt(cipherStringNdx);

                    //check is valid character
                    if (currentCharacter >= 'a' && currentCharacter <= 'z' || currentCharacter >= 'A' && currentCharacter <= 'Z')//<---lowercase a-z or uppercase A-Z 
                    {
                        graph += currentCharacter.ToString();
                        GraphNdx++;
                    }
                    else//<---not valid character
                    {
                        GraphNdx++;
                    }

                    //BREAK: meant to control the collection of remaining characters at end of cipher text that don't meet nGraph length: MAYNOTNEED
                    if (cipherStringNdx == (cipherLength - 1))
                        break;

                    //increment cipher string index
                    cipherStringNdx++;
                }//<---has 2 exit conditions: see BREAK

                //populate string lists
                graphList.Add(graph);

                //clean up
                graph = String.Empty;//<---reset graph string
            }

            //return graph list
            return graphList;
        }
        /*
        //  FUNC:   ProcessGraphPatterns (List arg)
        //  TASK:   Takes a list of strings, finds reapeated patterns, counts distanc between
        //  ARGS:   List of nGraph strings
        //  RTRN:   Dictionary
        */
        public static Dictionary<int,string> ProcessGraphPatterns(List<string> nGraph)
        {
            //local variables
            Dictionary<int, string> graphPatterns = new Dictionary<int, string>();//<--stores found repeated patterns and stores distance between as key value pair
            List<string> nGraphIter = nGraph;//<---makes copy of nGraph to iterate through
            int patternDistance = 0;//<---stores pattern distance
            int numCharacters = nGraph[0].Length;//<---stores number of characters in a signle pattern: used for distance between pattern math: used for last list index garbage graph check
            string pattern = String.Empty;//<---stores found pattern match

            //search for repeating patterns
            for (int baseNdx = 0; baseNdx < nGraph.Count; baseNdx++)//<---loop base compare
            {
                //compare each element in nGraph with each element in nGraphIter
                for (int iterNdx = 0; iterNdx < nGraphIter.Count; iterNdx++)//<--loop compare with base
                {
                    //if a match is found
                    if((nGraph[baseNdx] == nGraphIter[iterNdx]) && (baseNdx != iterNdx))
                    {
                        //store the pattern
                        pattern = nGraph[baseNdx];

                        //count the distance between occurrences: patternDistance = ((iterNdx - baseNdx) * numCharacters
                        patternDistance = Math.Abs((iterNdx - baseNdx) * numCharacters);//<---ensure none negative values

                        //if pattern is NOT already in dictionary
                        if (!graphPatterns.ContainsKey(patternDistance) && !graphPatterns.ContainsValue(pattern))
                        {
                            //store key value pair in dictionary
                            graphPatterns.Add(patternDistance, pattern);
                        }
                    }
                }
            }
            //return dirctionary
            return graphPatterns;
        }
        /*
        //  FUNC:   FactorDictionaries (Dictionary arg1, Dictionary arg2, Dictionary arg3)
        //  TASK:   Compiles most common factors found within each dictionary and returns a sorted list of those factors
        //  ARGS:   3 dictionaries from ProcessGraphPatterns(): arg1 di, arg2 tri, arg3 quad
        //  RTRN:   List<int>
        */
        public static List<int> FactorDictionaries(Dictionary<int, string> di, Dictionary<int, string> tri, Dictionary<int, string> quad)
        {
            //local variables
            List<int> factors = new List<int>();//<---list of considered factors

            //process dictionaries and increment individual list factors: TODO: May need to fix indexing
            //Di patterns__________________________________________________________________________
            foreach (int key in di.Keys)
            {
                int factorMax = (int)Math.Sqrt(key);//rounds down

                for(int tryFactor = 1; tryFactor <= factorMax; ++tryFactor)
                {
                    if(key % tryFactor == 0)
                    {
                        factors.Add(tryFactor);
                        if(tryFactor != key/tryFactor)
                        {
                            factors.Add(key / tryFactor);
                        }
                    }
                }
            }

            //Tri patterns_________________________________________________________________________
            foreach (int key in tri.Keys)
            {
                int factorMax = (int)Math.Sqrt(key);//rounds down

                for (int tryFactor = 1; tryFactor <= factorMax; ++tryFactor)
                {
                    if (key % tryFactor == 0)
                    {
                        factors.Add(tryFactor);
                        if (tryFactor != key / tryFactor)
                        {
                            factors.Add(key / tryFactor);
                        }
                    }
                }
            }

            //Quad patterns________________________________________________________________________
            foreach (int key in quad.Keys)//<---quad patterns
            {
                int factorMax = (int)Math.Sqrt(key);//rounds down

                for (int tryFactor = 1; tryFactor <= factorMax; ++tryFactor)
                {
                    if (key % tryFactor == 0)
                    {
                        factors.Add(tryFactor);
                        if (tryFactor != key / tryFactor)
                        {
                            factors.Add(key / tryFactor);
                        }
                    }
                }
            }

            //return factor list
            return factors;
        }
        /*
        //  FUNC:   AutoRefineFactorList(List arg)
        //  TASK:   Makes a series of educated guesses about the factors in the list to produce a more refined set of possible key lengths
        //  ARGS:   List<int>
        //  RTRN:   List<int>
        */
        public static Dictionary<int, int> AutoRefineFactorList(List<int> factors)
        {
            //local variables
            //List<int> refinedList = new List<int>();
            
            //remove highly unlikely factors
            factors.RemoveAll(n => n == 1);//<---remove 1
            factors.RemoveAll(n => n == 2);//<---remove 2
            factors.RemoveAll(n => n > 20);//<---remove factors over 20
            var dict = factors.GroupBy(n => n).ToDictionary(group => group.Key, group => group.Count());

            //group by matching factors: order from most occurring to least occurring factors
            //refinedList = factors;
            //suggest most occurring factor as key length
            //var group = factors.GroupBy(i => i).ToList();
            //int max = group.Max(c => c.Count());
            //var most = group.Where(d => d.Count() == max).Select(c => c.Key).ToList();

            return dict;
        }
        /*
        //  FUNC:   CipherToKeyLenSetsAnalysis(string arg, int arg)
        //  TASK:   After the probable key is found, break the cipher text into string sets with length = mProbKeyLength: Uses LetterFrequencyAnalysis()
        //  ARGS:   String cipher text, integer probable key length
        //  RTRN:   String
        */
        public static string CipherToKeyLenSets(string cipher, int probKey)
        {
            return cipher;
        }
        /*
        //  FUNC:   LetterFreqAnalysis()
        //  TASK:   NOTE: Used in CipherKeyLenSets
        //  ARGS:   
        //  RTRN:   
        */
        /*
        //  FUNC:   PrintPatterns (Dictionary arg)
        //  TASK:   Print the contents of a dictionary from process pattern
        //  ARGS:   Dictionary<int, string>
        //  RTRN:   Void
        */
        public static void PrintPatterns(Dictionary<int, string> inDict, int graphType)
        {
            Console.Write("\nPATTERNS________________________________________________________________\n");
            foreach (KeyValuePair<int, string> dict in inDict)
            {
                Console.Write("GraphType[" + graphType + "]:\t Distance: " + dict.Key + "\t Pattern: " + dict.Value + "\n");
            }
        }
        /*
        //  FUNC:   PrintFactors (List arg)
        //  TASK:   Print the contents of a list
        //  ARGS:   List<int>
        //  RTRN:   Void
        */
        public static void PrintFactors(List<int> factorList)
        {
            Console.Write("\nFACTORS_________________________________________________________________\n");
            foreach (int num in factorList)
            {
                Console.Write("Factor[" + num + "]\n");
            }
        }
        /*
        //  FUNC:   PrintAutoRefinedFactors (Dictionary arg)
        //  TASK:   Print the contents of a dictionary from auto refine factors
        //  ARGS:   Dictionary<int, string>
        //  RTRN:   Void
        */
        public static void PrintAutoRefinedFactors(Dictionary<int, int> inDict)
        {
            Console.Write("\nREFINED FACTORS_________________________________________________________\n");
            foreach (KeyValuePair<int, int> dict in inDict)
            {
                Console.Write("Refined Factor[" + dict.Key + "]\t Occurrences: " + dict.Value + "\n");
            }
        }
        //MAIN PROGRAM EXECUTION===================================================================
        static void Main(string[] args)
        {
            //Notes for testing
            //Cipher text  = UBPTKWVEFYGLYGMEKYTXIGUSXRKZIEVRMJUALZYLNRRWKVNXYWIPUSYFIISEDCVYINKGXWJASPSYMSFHSWGVVYIYALHXKAQGGVXKCSIELHKVQKWWDKEADGUXASNILVNGRFWXVUCMDEIFZEMWNWVVSXVFXAWAKRGJIUVRVWCCXYWZKVXGSGTWVUSWEXKQMXHVLLGXVHOCCKJWRUVSYMLVIEUCYRWKWCCJFJGGUSGLBTEDWVKTEGKCSISQXJVRHNYBFVJINVGMAICSWBSJEJDWHCIUQAJFWXGJESEWRVIMVZUGHEABQELTVURGLKIFYMFGZQIZFKUFJMGHRSDEYPZWFDIDOZFKHFVTFUGIESMPNLBUBISVKXCSPBKBWMJSRVZGHEGJRZKXEIIWWHIMRDWMVRGWXNWVDIEKIWLBTTFKXEFPHFCPPESXKFRLSMILVFIYTSEVQPVSSXVCIZJIJRUKSXZIMDYPHVJRKBMMSEWVLKLEYIOKYTQVVXQRGVWJIXYWGJRPEWHVIZFEOZPBLUCXJHIGTLBFDPRLSVAZRPZCRLYWTNVHZWXHYGHSTKJHJMDGRDPGUATJMDJESXKFRTDFXFVJEVZSGCYCRVVCERQXAHISFXJKTIPANWXYWZKVAMZUIPRGWDFVWWLXRXGRDFXAFIGXYSRFJSNLBKMVLRCDEGVICGYARCSYKEUILRAPCEHTFXREDTSFZETKQTPCOEUKLXDCCGYHMPFJNKLTWZKXCEGXLIRSDEYPZWFAHHSLLLGRWMSMXESMXVYINFZPZFJEDCIIJIHTVUXUWSKLBTYJWSHRQXJCREEYVQLRWXIGGVKXJVVXHLDQGLIFYMFLIRSDHVQDMLWQXXYLLGJSOAYIWIWMPJXTDFXRXLLGEINLLPPZKXUFYOSHCEGZSWDETKJGMDWQKEMLLYGEEVTTVTTJCCKKGRGXSMAUIIRUICJIYALTFVLAGVRZGPTVEEIPKEGVWDQDMRKJXYGLRIJLLKJGHEJGSDAWGWSEDILIUTCVYIYSCAYIWSHKLXTUNSWHMIJMGNUHMFFSHTYUSCCEGJMNIMLCYSTIGZQBMGYHTAIWTWSPBUUCGYSVIVWHXUUEZDYTVSYWZUITLMXVEGLCRSDEYPZWMJYHSCNICKXAWMPQVLMOVMGKOGKVFXIRMGKCCWFMXJMMXLHPQYSHGIELWXILVGTVZQBKGDJKZINRXXKUCHKZIFZIFJYVMDWWWUHXFFNPFGOGUZNDHTVRTPGZRMZYHITAVELQLLUCGVKXJVEWECCMJLVCKMHFWWSJWZKVXGSGPWKZIHFGNKIUMKKVGJMLLUCGVLSEFQFMHXWKWBRRRLAICMESWKRXAWJDTLDEVZSGVCHXIAFWKMHFCCWFMXJMMXLHPQIWJNVGMWXILVUSWEXKQMISGGKTRTAQNWIEGRXZIMFUBIJWXTZFTDAGSLHWVYEMHLTHFEMPRXXVCCXYWLKXLESHSWIWTTVWXFNTHRKQCCPYJURXZGRQWXAWMDYKZZKVXGSGTWVHSRLPTLCDRMAIVEEFVYRPRKWKWMXVXTWGAXGKLXVUBEXWXQKLXSATRTQWTVTNLUIMFFMPWPBUNTHSQXJVFTQIUTZYWFZWTKNTVGJIUZHXFNZIEFIFPELKCVRVVGKRELAACMWAGCEXLZUGIFXXJVIQHUCHVVIHWSKLCCZZWXPRQBFHPXZGRCCWXUOGMKQEEKMHFGTQFJEPUYFFMPQFXQCPLXSOILFJMBVHTHLDKISQHFVVGPTVKSGVZSGKNDFVUETIMXVIJXSQXJVGXFNGECARVVPEAATRTWEIVRVQQWMTZAQLPWHLTGVVICEHKWGPMEARHFVVWUUXVJEPPGHEGXXDWRVFJNKZDVTWWVFWHMNWZZWXPRQTKIUJZUMCCWBFQPWYARIKSGSHSWRAKQEAHJETHKGEEHYBJYPRUVIRCSRFYLVVKSWIGXKZDVKZIEFYGLYGMEKYTXIGUSTJWGVVZROAYIRREXJVKOFJDWZLMQEGHFNXRLWHVFHXLYGMFJEVVMGGWISSWVVYIIJYHMUWRVJIGLBXWGWVUFRTDGXPZLETPVXHLTWVFXCKMOWATRVJENDEQOYAPKSCNFVTFXLLZLIJFYLWUSZZKITFROAYIRREACCXPJIHXFOXQJEBYICJFJEHZVLLBPRUSWUVWLEYCXKZIAIIMMLCIUOMVYVXUIBQVFHCKMHFMUSISQCJWBNYCINUSODMMEYCXZFGNLHBFAIVFGTUBIGFYSCSSGMVHTOUNJIGQFVTEGSXRXYVQLRWXIGGVKFWKEIHLDZVVEFUMMAICECEEVVVBSFPRUSHXZWHJSHYGHSTKMGLBXWTDMORXXVWXECDIPUYEDYHELLLQIMSWXILVXMTJXFSDDVTAEEFYGLYGMEKYTXIGUSEVFYVCDWBFWTXYWWKXRBFADJEKEOFRHUNDFVJLGVRWGLHIUSWCZKHFMIEKASPGVHHIHECLSNRYGUBPZZDPCXIWWZTRJWTTFKKSGXRKZINZKALFNTFHYNRXXVVJXJLVCKIZAWPPCQMOGSKLUCXTWRVIEEZCVLCSRFJXAWWXEJUSWEXXJCCWLJKGEGRJIAIXJIYRJMWLPRZFXGIEZWHRCKSWMWSKUYCSKWHKENTFOPVPLLCKWNHJDVKLSKIVXYOAEIXSTDEMAICWWWPNLRWWLILVBYTZWWAWIMFFSHEIBLBTVKZIOREZFIGXYWGKMMEAUCEZVQKJWBGHRECDIFKLXMMDTVJEVZSGKGXWJASPLWHENWIKSWMWSKUYGITGQOVRWWXXRJLICUXASNRMRTIEYEKYYSAZLLVYMLJYHTFFWKSMEANNMEEEAUIYWHHIJWGTVXTJSBGESQCIEPWHIJLJXJVVIJIBMJARIWEKWUHXUAZKJMHFWWMVXHGJQHFXUMKRKGIEEVUQPRFOEYIVCCCXVJQUFJFWHBSEWCCEHFSNTVZWPFLVBFAPPCLLGUMLUOHWZGRCSSNLHTAJLVCKIZAYHYEVITKLXUIJRKWVKEWNJATRTQVWSVBUNWILKVGJTHFMTXFUSODYGAMIEUNEPTILAHHSLLLXZIMFUBGFFXKEYXVNDIDHLCJMSWUBMCAXCICUMCAHLHXJVMGXFJBFXQKCMMSLNLRJHYRVXSHSEUNMUVVLSHSIJHIEZEEDSILVARVISWMWIMFFSHKLXZYAMTGTVVVUGLCIZFJCEXKQUIXRUOTVKTAHTHKZIOZPBLUGCZXRQKXAWJDPZLMERPBFCIMRLMXVJHJNWIXNRWEXBDNWIMAIVTSGYUSEGLIFKLXALIETLMEJEGVBJQZDMCKIWSMJTVJMQIEKNHUSIUICKXAWXTPKSLCDPXLIUEGTEEZRCSHJEIQHWIMGYNWMJHITZSWXLDQVSVNPYGLCAGZNMNLRKWMITRJENPDXVNWIUAIOIIZAGTMEEMFTMTAHCSMSXKFRLDYSXYWEOVVBUUCWZVIQWXAWXJECWJHFVMLILIRCIPKLXNCTXTGRIJVNJUASIYEPZDTLCDRRFHVFQHTCAMQWXJVTXSMPRKJCVFHXXYCHZLWGCJUQFPXVLLGGVHYLPQJZEFVBISHSIUTIAFRWLBTEXWREPWVSJPGZLCVFEWECCMJLITKLXEUCHFNITKLXUIJVJWSHKLXKNPXZGREVHXVCIWDSRCXIFWHIXFLLGDEVNNWMJWBGIGBKYRECDIFFTXJUIMFFWYZXVZVPGBWRFVHHFHDZVEFGIXAWMPQVVEAFRPZCRLUAWUZHXFNVIEWVCCWXFWDYISKGUFRLBTOVFRGUC
            //Plain text =    chapter   Counterinsurgency in the Central Highlands By the end of      not only the US Mission but also for the first time President Diem recognized that the VC posed an immediate threat to the GVN presence in the Vietnamese countryside The growing sense of urgency was reinforced on the American side by the November election of John F Kennedy whose opponent Richard Nixon had accused him of being soft on communism Looking for an arena in which to establish his anticommunist credentials Kennedy selected the postcolonial nations as the new cold war battleground Soviet leader Nikita Khrushchev seemed to accept the challenge in a militant speech in January      in which he pledged support for socalled wars of national liberation  Kennedy came into office with the view that Laos bordering on both North and South Vietnam and on China Burma Thailand and Cambodia as well was the linchpin of US resistance to communism in Southeast Asia But the unfavorable prospects for the use of American ground forces there prompted him to compromise with the Soviets reinstalling the neutralist Souvanna Phouma as prime minister and preparing to negotiate a ceasefire between government and communist forces This compromise followed by the failure of the Bay of Pigs invasion of Cuba in April      risked provoking new Republican charges of a failure of effective anticommunist resolve At the same time insurgent gains in South Vietnam had erased the optimism of the late     s and the Diem regime suddenly looked vulnerable In these circumstances  the administration chose Vietnam as the focus of its resistance to communist expansion in Asia  The population distribution in South Vietnam reflected the countrys topography The nonVietnamese tribal groups that predominated in the highlands represented a small fraction of the South Vietnamese population Vietnam Declassified    Despite the damage to the agencys reputation inflicted by the Bay of Pigs disaster President Kennedy assigned CIA a significant share of the expanded effort in Vietnam In National Security Action Memorandum NSAM    of    May      he authorized a program for covert actions to be carried out by the Central Intelligence Agency which would precede and remain in force after any commitment of US forces to South Vietnam  As officials in Washington and Saigon worked to acquire and deploy new resources for the counterinsurgency effort in Vietnam the GVN position continued to deteriorate In October      the president sent his personal military representative General Maxwell Taylor and White House adviser on Vietnam Walt W Rostow to Saigon for a firsthand assessment They returned with recommendations for a massive new commitment including      troops Kennedy backed away from deploying ground forces but approved additional material and advisory support In this climate DCI Allen Dulles authorized the first major CIA counterinsurgency program since the signing of NSAM    On    October he endorsed a Saigon Station proposal to launch a village defense program in the lightly populated but strategically important Central Highlands  The CIAs counterinsurgency role grew after an interagency task force noted in January      that support to irregular formations fell under the jurisdiction of neither the MAAG nor the civilian aid mission called the US Operations Mission USOM The task force recommended instead that CIA be charged with this responsibility In May Defense Secretary McNamara went further promising Far East Division Chief Desmond FitzGerald a blank check    in terms of men money and materiel  During all the discussion about new strategies under the counterinsurgency rubric the US response to communist advances in South Vietnam continued to emphasize a military buildup The influx of military hardware and advisers  and especially the introduction of the helicopterborne infantry attack regained the military if not the political initiative for the GVN until the Viet Cong adapted their tactics and humiliated a superior ARVN force at the Delta hamlet of Ap Bac in January      During this period from early      until civil unrest paralyzed the Diem regime in mid     CIA innovations led the American side of the dual effort to weaken the Viet Congs rural organization and to mobilize the peasantry to defend itself By late      the programs had expanded beyond the agencys capacity to administer them and over the course of      the station ceded its management to the MACV This exercise called Operation Switchback ended on   November      the same day on which dissident generals encouraged by the Kennedy
            //Key = SUPERSECRET
            //Key Length = 11

            //local variables
            int diGraph = 2;
            int triGraph = 3;
            int quadGraph = 4;
            int keyLength = 0;
            Dictionary<char, double> FreqDict= new Dictionary<char, double>();
            Dictionary<int, string> patternDictionaryDi = new Dictionary<int, string>();
            Dictionary<int, string> patternDictionaryTri = new Dictionary<int, string>();
            Dictionary<int, string> patternDictionaryQuad = new Dictionary<int, string>();
            Dictionary<int, int> refinedFactorList = new Dictionary<int, int>();
            List<string> diGraphList = new List<string>();
            List<string> triGraphList = new List<string>();
            List<string> quadGraphList = new List<string>();
            List<int> factoredDictionaries = new List<int>();

            //fill dictionary(takes string filepath)
            FreqDict = FillFreqDict(mFilePath);

            //graph builder(takes int nGraph)
            diGraphList = GraphBuilder(diGraph);
            triGraphList = GraphBuilder(triGraph);
            quadGraphList = GraphBuilder(quadGraph);

            //process graph lists in ProcessGraphPatterns(takes list graphList)
            patternDictionaryDi = ProcessGraphPatterns(diGraphList);
            PrintPatterns(patternDictionaryDi, 2);
            patternDictionaryTri = ProcessGraphPatterns(triGraphList);
            PrintPatterns(patternDictionaryTri, 3);
            patternDictionaryQuad = ProcessGraphPatterns(quadGraphList);
            PrintPatterns(patternDictionaryQuad, 4);

            //process graph dictionaries in FindKeyLength(takes 3 dictionary patternDictioanaries (di, tri, quad))
            factoredDictionaries = FactorDictionaries(patternDictionaryDi, patternDictionaryTri, patternDictionaryQuad);
            PrintFactors(factoredDictionaries);

            //would you like to guess key length or auto refine?
            refinedFactorList = AutoRefineFactorList(factoredDictionaries);
            PrintAutoRefinedFactors(refinedFactorList);

            //would you like to guess key or keep processing?

            //keep console window open
            Console.ReadKey();

            //find key length(takes List nGraphList)
            //FindKeyWordLength(/*nGraphList*/);

            //break cipher into key length sets(takes string ciphertext, int probableKeyLength): NOTE: function call likely to be in while loop printing updated decrypted cipher message during analysis
            //CipherToKeyLenSetsAnalysis(/*cipherText*/, /*probable key length*/): NOTE: Uses LetterFreqAnalysis()
        }
    }
}
