using System;

abstract public class GospelLibrary
{
    public static List<Scripture> _scriptures = new List<Scripture>();// These are all the functions to make this prgram work. 

    public static void Load(string fileName){
        try{
            using(StreamReader reader = new StreamReader(fileName)){
                while(!reader.EndOfStream){
                    string line = reader.ReadLine();
                    string[] values = line.Split("||");
                    
                    string referenceText = values[0];
                    string scriptureText = values[1];
                    string[] scriptureWords = scriptureText.Split(" ");
                    List<Word> words = new List<Word>();
                    foreach(string scriptureWord in scriptureWords)
                    {
                        Word word = new Word(scriptureWord);
                        words.Add(word);
                    }

                    string book = referenceText.Substring(0, referenceText.LastIndexOf(" ")).Trim();
                    string chapterAndVerse = referenceText.Split(" ")[referenceText.Split(" ").Length-1];
                    string chapter = chapterAndVerse.Split(":")[0];
                    string verse = chapterAndVerse.Split(":")[1];
                    int startVerse = 0;
                    int endVerse = 0;
                    Reference reference;

                    if(!verse.Contains("-"))
                    {
                        startVerse = Convert.ToInt32(verse);
                        reference = new Reference(book, Convert.ToInt32(chapter), startVerse);
                    }
                    else
                    {
                        startVerse = Convert.ToInt32(verse.Split("-")[0]);
                        endVerse = Convert.ToInt32(verse.Split("-")[1]);
                        reference = new Reference(book, Convert.ToInt32(chapter), startVerse, endVerse);
                    }
                    Scripture scripture = new Scripture(reference, words);
                    _scriptures.Add(scripture);
                }
            }
        }catch(Exception i){
            Console.WriteLine($"Error readin file from; file name: {i.Message}");
        }
    }
}