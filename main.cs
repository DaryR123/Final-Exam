using System; 
using System.Collections; 

class Artist { 
      
    public string FirstName { get; set; }  
    public string LastName { get; set; }  
    public string Email { get; set; }
    
    
    public Artist(string firstName, string lastName)
    {
        this.FirstName=firstName;
        this.LastName=lastName;
        this.Email="unknown";
    }
    
    
    public void Display() 
    { 
        Console.WriteLine("Artist info: "+this.FirstName+" "+this.LastName);
    } 
} 
 



class Song { 
     
    long id;
    public long Id {
        get{
            return id;
        }
        set{
            
            if (value.ToString().Length != 10){
                Console.WriteLine("\nId should be exaclty 10 for song title "+this.Title);
            }
            id=value;
        }
    }  
    
    public string Title { get; set; }  
    public Artist ArtistInfo { get; set; }
    
    public Song(){} 
    
    public Song(long id, string title)
    {
        this.Title=title;
        this.Id=id;
    } 
  
    public void AddArtistInfo(Artist artist) 
    { 
        this.ArtistInfo=artist;
        Console.WriteLine("Artist "+this.ArtistInfo.FirstName+" "+this.ArtistInfo.LastName+
                          " added to the song titled "+this.Title);
    } 
    
    public void Display() 
    { 
        Console.WriteLine("Song info: "+this.Id+" "+this.Title+" "+
                           this.ArtistInfo.FirstName+" "+this.ArtistInfo.LastName);
    } 
} 
  



class Testing { 
  
    static public void Main() 
    { 
        
        Artist artist = new Artist("Taylor","Swift"); 
        artist.Display(); 
        
        Song s1 = new Song(1249475837,"Girl at home");
        Song s2 = new Song(2094756175,"The Last Time");
        Song s3 = new Song(3647581041,"The moment I knew");
      
        Console.WriteLine();
        s1.AddArtistInfo(artist);
        s2.AddArtistInfo(artist);
        s3.AddArtistInfo(artist);
        
        Console.WriteLine();
        s1.Display();
        s2.Display();
        s3.Display();
    }  
}