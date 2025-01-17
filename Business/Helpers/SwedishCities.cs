

namespace Business.Helpers;


// Detta är genererat av Chat GPT 4.0 - Jag skapade en extra klass i Helpers för att hålla en lista över svenska orter.
// Det gör att jag kan validera enbart svenska orter utan att använda ett regex för specifika namn.
// Jag fick ett true värde tillbaka från mitt enhetstest när jag använde ett regex när jag förväntade mig false, alltså i min Arrange - string city = "New York".
public static class SwedishCities 
{
    public static readonly HashSet<string> Cities = new(StringComparer.OrdinalIgnoreCase)
    {
        "Stockholm", "Göteborg", "Malmö", "Uppsala", "Västerås",
        "Örebro", "Linköping", "Helsingborg", "Jönköping", "Norrköping",
        "Lund", "Umeå", "Gävle", "Borås", "Södertälje", "Eskilstuna",
        "Karlstad", "Täby", "Halmstad", "Sundsvall", "Luleå", "Trollhättan",
        "Östersund", "Kiruna"
    };
}
