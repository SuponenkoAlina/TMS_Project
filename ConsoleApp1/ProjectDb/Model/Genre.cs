using System.ComponentModel;

namespace ProjectDb.Model
{
    public enum Genre
    {
        [Description("Детектив")]
        detect = 0,
        [Description("Комедия")]
        comedy = 1,
        [Description("Роман")]
        roman = 2,
        [Description("Сказки")]
        fairytails = 3,
        [Description("Приключения")]
        prikl = 4,
        [Description("Фантастика")]
        fantasy = 5,
        [Description("Детская литература")]
        children = 6,
        [Description("Проза")]
        proza = 7,
        [Description("Юмор")]
        humor = 8,
        [Description("Научная литература")]
        nauch = 9,
        [Description("Книги о психологии")]
        psyhology = 10,
    }
 
}
