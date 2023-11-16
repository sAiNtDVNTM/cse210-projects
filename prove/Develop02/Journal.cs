using System;

abstract class Journal
{
    public static List<Entry> _entries = new List<Entry>();// These are all the functions to make this journal work 

    public static void userAddEntry(Entry entry){
        _entries.Add(entry);
    }

    public static void DisplayUserEntries(){
        foreach(Entry entry in _entries){
            entry.DisplayEntry();
        }
    }

    public static void SaveToAFile(string fileName){
        try {
            using (StreamWriter writer = new StreamWriter(fileName)){ 
                foreach (Entry entry in _entries){
                    writer.WriteLine($"{entry._date}||{entry._promptText}||{entry._entryText}");
                }
            }
            Console.WriteLine($"Journal Entries save to {fileName}");
        }catch(Exception i){
            Console.WriteLine($"Erro to save under {fileName}{i.Message}");

        }
    }

    public static void LoadFromFile(string fileName){
        try{
            using(StreamReader reader = new StreamReader(fileName)){
                while(!reader.EndOfStream){
                    string line = reader.ReadLine();
                    string[] values = line.Split("||");
                    Entry entry = new Entry(values[0], values[1], values[2]);
                    _entries.Add(entry);
                }
            }
        }catch(Exception i){
            Console.WriteLine($"Error readin file from; file name: {i.Message}");
        }
    }
}