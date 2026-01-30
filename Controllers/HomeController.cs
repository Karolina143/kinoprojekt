using Microsoft.AspNetCore.Mvc;
using kinoprojekt.Models;
using System.Linq;

namespace kinoprojekt.Controllers
{
    public class HomeController : Controller
    {
       private readonly List<Film> _filmy = new List<Film>
{
    new Film { 
        Id = 1, Tytul = "Wonka", Obrazek = "/images/wonka.jpg", CzasTrwania = "116 min", Godziny = "12:00, 15:30", 
        Kategoria = "Przygodowy", Rezyseria = "Paul King", Obsada = "Timothée Chalamet, Hugh Grant", 
        Opis = "Niezwykła historia o tym, jak największy na świecie wynalazca stał się ukochanym Willym Wonką.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=otNh9bTjXWg" 
    },
    new Film { 
        Id = 2, Tytul = "Matrix", Obrazek = "/images/matrix.jpg", CzasTrwania = "136 min", Godziny = "18:00, 21:00", 
        Kategoria = "Sci-Fi", Rezyseria = "Lana Wachowski", Obsada = "Keanu Reeves, Carrie-Anne Moss", 
        Opis = "Haker odkrywa, że rzeczywistość jest symulacją stworzoną przez maszyny.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=vKQi3bBA1y8" 
    },
    new Film { 
        Id = 3, Tytul = "Minionki", Obrazek = "/images/minionki.jpg", CzasTrwania = "91 min", Godziny = "10:00, 13:00", 
        Kategoria = "Animacja", Rezyseria = "Kyle Balda", Obsada = "Brak (Animacja)", 
        Opis = "Małe, żółte stworki wyruszają w podróż, by znaleźć nowego złoczyńcę, któremu mogłyby służyć.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=Ngev6zpUisw" 
    },
    new Film { 
        Id = 4, Tytul = "Joker", Obrazek = "/images/joker.jpg", CzasTrwania = "122 min", Godziny = "20:00, 23:00", 
        Kategoria = "Dramat", Rezyseria = "Todd Phillips", Obsada = "Joaquin Phoenix, Lady Gaga", 
        Opis = "Mroczna historia Artura Flecka i jego transformacji w kultowego złoczyńcę.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=awOK70kHV48" 
    },
    new Film { 
        Id = 5, Tytul = "Napoleon", Obrazek = "/images/napoleon.jpg", CzasTrwania = "158 min", Godziny = "17:00, 20:30", 
        Kategoria = "Biograficzny", Rezyseria = "Ridley Scott", Obsada = "Joaquin Phoenix, Vanessa Kirby", 
        Opis = "Epickie spojrzenie na drogę do władzy i upadek francuskiego cesarza Napoleona Bonaparte.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=OAZWXUkrjPc" 
    },
    new Film { 
        Id = 6, Tytul = "Zakonnica", Obrazek = "/images/zakonnica.jpg", CzasTrwania = "96 min", Godziny = "22:00", 
        Kategoria = "Horror", Rezyseria = "Michael Chaves", Obsada = "Taissa Farmiga, Jonas Bloquet", 
        Opis = "Demony przeszłości powracają w klasztorze, gdzie czai się najmroczniejsze zło.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=QF-oyCwaArU" 
    },
    new Film { 
        Id = 7, Tytul = "Deadpool", Obrazek = "/images/deadpool.jpg", CzasTrwania = "108 min", Godziny = "19:00, 21:30", 
        Kategoria = "Akcja", Rezyseria = "Shawn Levy", Obsada = "Ryan Reynolds, Hugh Jackman", 
        Opis = "Deadpool i Wolverine łączą siły, by uratować świat w najbardziej niegrzeczny sposób.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=73_1biulkYk" 
    },
    new Film { 
        Id = 8, Tytul = "Oppenheimer", Obrazek = "/images/oppemheimer.jpg", CzasTrwania = "180 min", Godziny = "16:00, 20:00", 
        Kategoria = "Biograficzny", Rezyseria = "Christopher Nolan", Obsada = "Cillian Murphy, Emily Blunt", 
        Opis = "Historia J. Roberta Oppenheimera i jego roli w stworzeniu bomby atomowej.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=2CXFpWTxS3M" 
    },
    new Film { 
        Id = 9, Tytul = "Diuna", Obrazek = "/images/diuna.jpg", CzasTrwania = "166 min", Godziny = "15:00, 19:30", 
        Kategoria = "Sci-Fi", Rezyseria = "Denis Villeneuve", Obsada = "Timothée Chalamet, Zendaya", 
        Opis = "Paul Atryda wyrusza na niebezpieczną planetę Arrakis, by zapewnić przyszłość swojemu ludowi.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=ANgIWiAxq_U" 
    },
    new Film { 
        Id = 10, Tytul = "The Marvels", Obrazek = "/images/the marvels.jpg", CzasTrwania = "105 min", Godziny = "13:00, 16:00", 
        Kategoria = "Akcja", Rezyseria = "Nia DaCosta", Obsada = "Brie Larson, Iman Vellani", 
        Opis = "Carol Danvers, Kamala Khan i Monica Rambeau muszą połączyć siły jako trio.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=wS_qbDztgVY" 
    },
    new Film { 
        Id = 11, Tytul = "Piła X", Obrazek = "/images/pilaX.jpg", CzasTrwania = "118 min", Godziny = "21:00, 23:30", 
        Kategoria = "Horror", Rezyseria = "Kevin Greutert", Obsada = "Tobin Bell, Shawnee Smith", 
        Opis = "John Kramer wraca, by wziąć odwet na oszustach, którzy obiecali mu cudowne lekarstwo.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=ZtusYk4Dpmo" 
    },
    new Film { 
        Id = 12, Tytul = "Wiedźmin", Obrazek = "/images/wiedzmin.jpg", CzasTrwania = "120 min", Godziny = "18:30", 
        Kategoria = "Fantasy", Rezyseria = "Tomasz Bagiński", Obsada = "Liam Hemsworth, Anya Chalotra", 
        Opis = "Geralt z Rivii, zmutowany łowca potworów, szuka swojego miejsca w pełnym okrucieństwa świecie.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=9ix7TUGVYIo" 
    },
    new Film { 
        Id = 13, Tytul = "Batman", Obrazek = "/images/batman.jpg", CzasTrwania = "176 min", Godziny = "19:00", 
        Kategoria = "Akcja", Rezyseria = "Matt Reeves", Obsada = "Robert Pattinson, Zoë Kravitz", 
        Opis = "Młody Batman tropi seryjnego mordercę Riddlera, który terroryzuje Gotham City.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=mqqft2x_Aa4" 
    },
    new Film { 
        Id = 14, Tytul = "Gladiator", Obrazek = "/images/gladiator.jpg", CzasTrwania = "150 min", Godziny = "17:30, 21:00", 
        Kategoria = "Dramat", Rezyseria = "Ridley Scott", Obsada = "Paul Mescal, Pedro Pascal", 
        Opis = "Epicka kontynuacja walk na arenie rzymskiego Koloseum.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=WVgDrI6keck" 
    },
    new Film { 
        Id = 15, Tytul = "Shrek 5", Obrazek = "/images/shrek5.jpg", CzasTrwania = "95 min", Godziny = "11:00, 14:00", 
        Kategoria = "Animacja", Rezyseria = "Walt Dohrn", Obsada = "Brak (Animacja)", 
        Opis = "Powrót zielonego ogra i jego wesołej ferajny w zupełnie nowej przygodzie.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=0rhcEXJ14Rg" 
    },
    new Film { 
        Id = 16, Tytul = "Godzilla", Obrazek = "/images/godzilla.jpg", CzasTrwania = "123 min", Godziny = "15:30", 
        Kategoria = "Sci-Fi", Rezyseria = "Takashi Yamazaki", Obsada = "Ryunosuke Kamiki", 
        Opis = "Potężny potwór powraca, by rzucić wyzwanie ludzkości.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=odM92ap8_c0" 
    },
    new Film { 
        Id = 17, Tytul = "Spider-Man", Obrazek = "/images/spiderman.jpg", CzasTrwania = "148 min", Godziny = "12:00, 18:00", 
        Kategoria = "Animacja", Rezyseria = "Joaquim Dos Santos", Obsada = "Brak (Animacja)", 
        Opis = "Miles Morales podróżuje przez uniwersum, spotykając inne wersje Spider-Mana.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=JfVOs4VSpmA" 
    },
    new Film { 
        Id = 18, Tytul = "Avatar", Obrazek = "/images/avatar.jpg", CzasTrwania = "162 min", Godziny = "14:00, 19:00", 
        Kategoria = "Fantasy", Rezyseria = "James Cameron", Obsada = "Sam Worthington, Zoe Saldaña", 
        Opis = "Wizualna podróż na planetę Pandorę, gdzie trwa walka o przetrwanie natury.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=5PSNL1qAk6Y" 
    },
    new Film { 
        Id = 19, Tytul = "Top Gun", Obrazek = "/images/topgun.jpg", CzasTrwania = "130 min", Godziny = "16:30, 20:30", 
        Kategoria = "Akcja", Rezyseria = "Joseph Kosinski", Obsada = "Tom Cruise, Miles Teller", 
        Opis = "Maverick wraca do kokpitu, szkoląc nową generację pilotów do trudnej misji.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=giXco2jaZ_4" 
    },
    new Film { 
        Id = 20, Tytul = "Barbie", Obrazek = "/images/barbie.jpg", CzasTrwania = "114 min", Godziny = "13:00, 17:00", 
        Kategoria = "Fantasy", Rezyseria = "Greta Gerwig", Obsada = "Margot Robbie, Ryan Gosling", 
        Opis = "Barbie opuszcza Barbieland i odkrywa, że prawdziwy świat jest zupełnie inny.", 
        ZwiastunUrl = "https://www.youtube.com/watch?v=pBk4NYhWNMM" 
    }
};
private readonly List<string> _miasta = new List<string> { "Warszawa", "Kraków", "Wrocław", "Gdańsk", "Poznań", "Kielce", "Białystok", "Lublin" };

public IActionResult WybierzTermin(int id)
{
    var film = _filmy.FirstOrDefault(f => f.Id == id);
    ViewBag.Miasta = _miasta; 
    return View(film);
}
public IActionResult SalaKinowa(int id, string miasto = "Kielce", string data = "Dzisiaj", string godzina = "18:00")
{
    var film = _filmy.FirstOrDefault(f => f.Id == id);
    ViewBag.Miasto = miasto;
    ViewBag.Data = data;
    ViewBag.Godzina = godzina;
    return View(film);
}
        public IActionResult Index(string searchString)
{
    
    var filmy = _filmy;

    if (!string.IsNullOrEmpty(searchString))
    {
       
        filmy = filmy.Where(f => f.Tytul.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
    }


    return View(filmy);
}
       public IActionResult Szczegoly(int id) => View(_filmy.FirstOrDefault(f => f.Id == id));

    public IActionResult Zaloguj()
    {
        return View();
    }

    public IActionResult Rejestracja()
{
    ViewBag.Miasta = _miasta; 
    return View();
}
public IActionResult MojeKonto() => View();
public IActionResult Wkrotce()
{
    return View();
}
} 
}