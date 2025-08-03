using CanadianNationalParks.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace CanadianNationalParks.Data
{
    public static class ParkRepository
    {
        public static List<NationalPark> GetAllParks() => new List<NationalPark>
{
    new NationalPark { Name = "Akami-Uapishkᵁ-KakKasuak-Mealy Mountains", ProvinceOrTerritory = "Newfoundland & Labrador / Quebec", NotableAnimals = "Caribou, Black Bear, Arctic Fox" },
    new NationalPark { Name = "Aulavik", ProvinceOrTerritory = "Northwest Territories", NotableAnimals = "Muskox, Arctic Hare, Snowy Owl" },
    new NationalPark { Name = "Auyuittuq", ProvinceOrTerritory = "Nunavut", NotableAnimals = "Arctic Fox, Polar Bear, Seal" },
    new NationalPark { Name = "Banff", ProvinceOrTerritory = "Alberta", NotableAnimals = "Elk, Grizzly Bear, Mountain Goat, Wolf" },
    new NationalPark { Name = "Bruce Peninsula", ProvinceOrTerritory = "Ontario", NotableAnimals = "Black Bear, Massasauga Rattlesnake, Deer" },
    new NationalPark { Name = "Cape Breton Highlands", ProvinceOrTerritory = "Nova Scotia", NotableAnimals = "Moose, Bobcat, Coyote" },
    new NationalPark { Name = "Elk Island", ProvinceOrTerritory = "Alberta", NotableAnimals = "Plains Bison, Elk, Beaver" },
    new NationalPark { Name = "Forillon", ProvinceOrTerritory = "Quebec", NotableAnimals = "Black Bear, Red Fox, Whale" },
    new NationalPark { Name = "Fundy", ProvinceOrTerritory = "New Brunswick", NotableAnimals = "Moose, Beaver, Peregrine Falcon" },
    new NationalPark { Name = "Georgian Bay Islands", ProvinceOrTerritory = "Ontario", NotableAnimals = "Beaver, Osprey, White-tailed Deer" },
    new NationalPark { Name = "Glacier", ProvinceOrTerritory = "British Columbia", NotableAnimals = "Wolverine, Mountain Goat, Lynx" },
    new NationalPark { Name = "Grasslands", ProvinceOrTerritory = "Saskatchewan", NotableAnimals = "Prairie Dog, Bison, Swift Fox" },
    new NationalPark { Name = "Gros Morne", ProvinceOrTerritory = "Newfoundland & Labrador", NotableAnimals = "Caribou, Black Bear, Arctic Hare" },
    new NationalPark { Name = "Gulf Islands", ProvinceOrTerritory = "British Columbia", NotableAnimals = "Sea Lion, Bald Eagle, Orca" },
    new NationalPark { Name = "Gwaii Haanas", ProvinceOrTerritory = "British Columbia", NotableAnimals = "Humpback Whale, Sea Lion, Bald Eagle" },
    new NationalPark { Name = "Ivvavik", ProvinceOrTerritory = "Yukon", NotableAnimals = "Muskox, Caribou, Arctic Fox" },
    new NationalPark { Name = "Jasper", ProvinceOrTerritory = "Alberta", NotableAnimals = "Moose, Black Bear, Caribou, Bighorn Sheep" },
    new NationalPark { Name = "Kejimkujik", ProvinceOrTerritory = "Nova Scotia", NotableAnimals = "River Otter, Barred Owl, Snapping Turtle" },
    new NationalPark { Name = "Kluane", ProvinceOrTerritory = "Yukon / BC", NotableAnimals = "Dall Sheep, Grizzly Bear, Golden Eagle" },
    new NationalPark { Name = "Kootenay", ProvinceOrTerritory = "British Columbia", NotableAnimals = "Elk, Mountain Goat, Black Bear" },
    new NationalPark { Name = "Kouchibouguac", ProvinceOrTerritory = "New Brunswick", NotableAnimals = "Grey Seal, Snowy Owl, White-tailed Deer" },
    new NationalPark { Name = "La Mauricie", ProvinceOrTerritory = "Quebec", NotableAnimals = "Moose, Loon, Black Bear" },
    new NationalPark { Name = "Mingan Archipelago", ProvinceOrTerritory = "Quebec", NotableAnimals = "Puffin, Seal, Seabirds" },
    new NationalPark { Name = "Mount Revelstoke", ProvinceOrTerritory = "British Columbia", NotableAnimals = "Black Bear, Marmot, Mountain Goat" },
    new NationalPark { Name = "Nahanni", ProvinceOrTerritory = "Northwest Territories", NotableAnimals = "Moose, Grizzly Bear, Peregrine Falcon" },
    new NationalPark { Name = "Nááts’įhch’oh", ProvinceOrTerritory = "Northwest Territories", NotableAnimals = "Wolverine, Caribou, Bear" },
    new NationalPark { Name = "Pacific Rim", ProvinceOrTerritory = "British Columbia", NotableAnimals = "Black Bear, Sea Otter, Grey Whale" },
    new NationalPark { Name = "Pituamkek", ProvinceOrTerritory = "Prince Edward Island", NotableAnimals = "Red Fox, Seabirds, Beaver" },
    new NationalPark { Name = "Point Pelee", ProvinceOrTerritory = "Ontario", NotableAnimals = "Monarch Butterfly, Raccoon, Fox" },
    new NationalPark { Name = "Prince Albert", ProvinceOrTerritory = "Saskatchewan", NotableAnimals = "Elk, Lynx, Black Bear" },
    new NationalPark { Name = "Prince Edward Island", ProvinceOrTerritory = "Prince Edward Island", NotableAnimals = "Red Fox, Cormorant, Seal" },
    new NationalPark { Name = "Pukaskwa", ProvinceOrTerritory = "Ontario", NotableAnimals = "Black Bear, Moose, Lynx" },
    new NationalPark { Name = "Qausuittuq", ProvinceOrTerritory = "Nunavut", NotableAnimals = "Arctic Hare, Polar Bear, Muskox" },
    new NationalPark { Name = "Quttinirpaaq", ProvinceOrTerritory = "Nunavut", NotableAnimals = "Muskox, Arctic Hare, Polar Bear" },
    new NationalPark { Name = "Riding Mountain", ProvinceOrTerritory = "Manitoba", NotableAnimals = "Black Bear, Elk, Lynx" },
    new NationalPark { Name = "Rouge Urban", ProvinceOrTerritory = "Ontario", NotableAnimals = "Deer, Coyote, Snapping Turtle" },
    new NationalPark { Name = "Sable Island", ProvinceOrTerritory = "Nova Scotia", NotableAnimals = "Wild Horses, Grey Seals, Seabirds" },
    new NationalPark { Name = "Sirmilik", ProvinceOrTerritory = "Nunavut", NotableAnimals = "Narwhal, Beluga Whale, Polar Bear" },
    new NationalPark { Name = "Terra Nova", ProvinceOrTerritory = "Newfoundland & Labrador", NotableAnimals = "Red Fox, Moose, Beaver" },
    new NationalPark { Name = "Thaidene Nëné", ProvinceOrTerritory = "Northwest Territories", NotableAnimals = "Caribou, Arctic Fox, Wolf" },
    new NationalPark { Name = "Thousand Islands", ProvinceOrTerritory = "Ontario", NotableAnimals = "Beaver, Osprey, White-tailed Deer" },
    new NationalPark { Name = "Torngat Mountains", ProvinceOrTerritory = "Newfoundland & Labrador", NotableAnimals = "Polar Bear, Arctic Wolf, Caribou" },
    new NationalPark { Name = "Tuktut Nogait", ProvinceOrTerritory = "Northwest Territories", NotableAnimals = "Caribou, Arctic Wolf, Falcon" },
    new NationalPark { Name = "Ukkusiksalik", ProvinceOrTerritory = "Nunavut", NotableAnimals = "Polar Bear, Arctic Fox, Caribou" },
    new NationalPark { Name = "Vuntut", ProvinceOrTerritory = "Yukon", NotableAnimals = "Porcupine Caribou, Wolf, Snowy Owl" },
    new NationalPark { Name = "Wapusk", ProvinceOrTerritory = "Manitoba", NotableAnimals = "Polar Bear, Arctic Fox, Caribou" },
    new NationalPark { Name = "Waterton Lakes", ProvinceOrTerritory = "Alberta", NotableAnimals = "Cougar, Deer, Black Bear, Bald Eagle" },
    new NationalPark { Name = "Wood Buffalo", ProvinceOrTerritory = "Alberta / NWT", NotableAnimals = "Bison, Whooping Crane, Wolf" },
    new NationalPark { Name = "Yoho", ProvinceOrTerritory = "British Columbia", NotableAnimals = "Grizzly Bear, Marmot, Mountain Goat" }
};

    }
}

