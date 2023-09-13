using System.Collections.Generic;

namespace ParserDoski.Core.KupiProday
{
    internal class Selectable
    {
        public Dictionary<string, string> searchRegion { get; } = new Dictionary<string, string>
        {
            { "Адыгея", "https://adygheya." },
            { "Алтайский край", "https://barnaul." },
            { "Амурская область", "https://blagoveshchensk." },
            { "Архангельская область", "https://arh." },
            { "Астраханская область", "https://astrakhan." },
            { "Башкортостан", "https://ufa." },
            { "Белгородская область", "https://bel." },
            { "Брянская область", "https://bryansk." },
            { "Бурятия", "https://bur." },
            { "Владимирская область", "https://vl." },
            { "Волгоградская область", "https://vol." },
            { "Вологодская область", "https://vologda." },
            { "Воронежская область", "https://voronezh." },
            { "Дагестан", "https://dagestan." },
            { "Еврейская АО", "https://eao." },
            { "Забайкальский край", "https://chita." },
            { "Ивановская область", "https://iv." },
            { "Ингушетия", "https://magas." },
            { "Иркутская область", "https://irk." },
            { "Кабардино-Балкария", "https://kbr." },
            { "Калининградская область", "https://kaliningrad." },
            { "Калмыкия", "https://kalmykia." },
            { "Калужская область", "https://kaluga." },
            { "Камчатский край", "https://kamchatka." },
            { "Карачаево-Черкесия", "https://kchr." },
            { "Карелия", "https://karelia." },
            { "Кемеровская область", "https://kem." },
            { "Кировская область", "https://kirov." },
            { "Коми", "https://komi." },
            { "Костромская область", "https://kostroma." },
            { "Краснодарский край", "https://krasnodar." },
            { "Красноярский край", "https://krasnoyarsk." },
            { "Курганская область", "https://kurgan." },
            { "Курская область", "https://kursk." },
            { "Ленинградская область", "https://lenobl." },
            { "Липецкая область", "https://lipetsk." },
            { "Магаданская область", "https://magadan." },
            { "Марий Эл", "https://mari." },
            { "Мордовия", "https://mordovia." },
            { "Москва", "https://msk." },
            { "Московская область", "https://mo." },
            { "Мурманская область", "https://murman." },
            { "Ненецкий АО", "https://nao." },
            { "Нижегородская область", "https://nnov." },
            { "Новгородская область", "https://nov." },
            { "Новосибирская область", "https://nsk." },
            { "Омская область", "https://omsk." },
            { "Оренбургская область", "https://oren." },
            { "Орловская область", "https://orel." },
            { "Пензенская область", "https://penza." },
            { "Пермский край", "https://perm." },
            { "Приморский край", "https://primorsky." },
            { "Псковская область", "https://pskov." },
            { "Республика Алтай", "https://altai." },
            { "Ростовская область", "https://rostov." },
            { "Рязанская область", "https://rzn." },
            { "Самарская область", "https://samara." },
            { "Санкт-Петербург", "https://spb." },
            { "Саратовская область", "https://saratov." },
            { "Саха (Якутия)", "https://sakha." },
            { "Сахалинская область", "https://sakhalin." },
            { "Свердловская область", "https://ek." },
            { "Северная Осетия", "https://osetia." },
            { "Смоленская область", "https://smol." },
            { "Ставропольский край", "https://stav." },
            { "Тамбовская область", "https://tambov." },
            { "Татарстан", "https://tatarstan." },
            { "Тверская область", "https://tver." },
            { "Томская область", "https://tomsk." },
            { "Тульская область", "https://tula." },
            { "Тыва", "https://tuva." },
            { "Тюменская область", "https://tyumen." },
            { "Удмуртия", "https://udm." },
            { "Ульяновская область", "https://ul." },
            { "Хабаровский край", "https://khb." },
            { "Хакасия", "https://khakas." },
            { "Ханты-Мансийский АО", "https://hmao." },
            { "Челябинская область", "https://chel." },
            { "Чеченская республика", "https://chr." },
            { "Чувашия", "https://chuvashia." },
            { "Чукотский АО", "https://chukotka." },
            { "Ямало-Ненецкий АО", "https://yamal." },
            { "Ярославская область", "https://yar." }
        };

        public Dictionary<string, string> searchCategory { get; } = new Dictionary<string, string>
        {
            { "Транспорт", "/auto" },
            { "Недвижимость", "/realty" },
            { "Личные вещи", "/lichnoe" },
            { "Электроника, техника", "/office" },
            { "Дом и сад, мебель, бытовое", "/vashdom" },
            { "Текстиль", "/textile" },
            { "Животные", "/zhivotnye" },
            { "Услуги и предложения", "/uslugi" },
            { "Работа", "/rabota" },
            { "Хобби, Отдых, Спорт", "/otdyh" },
            { "Оборудование", "/oborud" },
            { "Сырье", "/raw" },
            { "Строительные товары и услуги", "/stroitel" },
            { "Продукты питания", "/produkt" }
        };

        public Dictionary<string, string> transport { get; } = new Dictionary<string, string>
        {
            { "Мотоциклы и мототехника", "/all_mototehnika" },
            { "Грузовики и спецтехника", "/all_gruzoviki" },
            { "Автомобили", "/all_cars" },
            { "Водный транспорт", "/all_lodki" },
            { "Запчасти и аксессуары", "/all_zapchasti" },
            { "Грузоперевозки", "/all_gruz" },
            { "Другое", "/all_autoraznoe" }
        };

        public Dictionary<string, string> nedvizhimost { get; } = new Dictionary<string, string>
        {
            { "Квартиры", "/all_kvartiry" },
            { "Дома, дачи, коттеджи", "/all_dom" },
            { "Комнаты", "/all_komnaty" },
            { "Коммерческая", "/all_kommercheskaya" },
            { "Земельные участки", "/all_zemlya" },
            { "Гаражи и машиноместа", "/all_garazhi" },
            { "Недвижимость за рубежом", "/all_zagranrealty" }
        };

        public Dictionary<string, string> lichnoe { get; } = new Dictionary<string, string>
        {
            { "Женская одежда, обувь", "/all_odezhdaobuv" },
            { "Мужская одежда, обувь", "/all_odezhdamuzhskaya/" },
            { "Детский мир", "/all_detmir" },
            { "Красота и здоровье", "/all_krasota" },
            { "Аксессуары", "/all_aksessuary" }
        };

        public Dictionary<string, string> elektronika { get; } = new Dictionary<string, string>
        {
            { "Электроника", "/all_comp" },
            { "Техника для дома", "/all_bittexno" },
            { "Техника для кухни", "/all_kuhtexno" },
            { "Климатическая техника", "/all_klimattexno" },
            { "Личное и гигиена", "/all_lichtexno" }
        };

        public Dictionary<string, string> domSad { get; } = new Dictionary<string, string>
        {
            { "Мебель", "/all_mebel" },
            { "Интерьер", "/all_interior" },
            { "Посуда, все для кухни", "/all_posuda" },
            { "Освещение", "/all_svet" },
            { "Бытовая химия", "/all_bitovayahimiya" },
            { "Сад и огород", "/all_sadogorod" }
        };

        public Dictionary<string, string> tekstil { get; } = new Dictionary<string, string>
        {
            { "Ткани", "/all_tkani" },
            { "КПБ, полотенца, скатерти", "/all_kpb" },
            { "Рабочая одежда", "/all_rabodeg" },
            { "Другое", "/all_textilmore" }
        };

        public Dictionary<string, string> zhivotnie { get; } = new Dictionary<string, string>
        {
            { "Собаки", "/all_sobaki" },
            { "Кошки", "/all_koshki" },
            { "Аквариум", "/all_akvarium" },
            { "Птицы", "/all_ptitsy" },
            { "Товары и услуги для животных", "/all_tovary" },
            { "Другие животные", "/all_bolshe" }
        };

        public Dictionary<string, string> uslugi { get; } = new Dictionary<string, string>
        {
            { "Юридические услуги", "/all_yuridicheskie" },
            { "Бухгалтерские услуги", "/all_buhgalterskie" },
            { "Ремонт техники", "/all_remonttehniki" },
            { "IT", "/all_it" },
            { "Безопасность, детективы", "/all_bezopasnost" },
            { "Образование, курсы", "/all_obrazovanie" },
            { "Переводы, Набор текста", "/all_perevody" },
            { "Развлечение, Праздники", "/all_razvlecheniya" },
            { "Другие виды услуг", "/all_vseuslugi" }
        };

        public Dictionary<string, string> rabota { get; } = new Dictionary<string, string>
        {
            { "Вакансии", "/all_vakansii" },
            { "Резюме", "/all_rezume" }
        };

        public Dictionary<string, string> hobbi { get; } = new Dictionary<string, string>
        {
            { "Билеты и путешествия", "/all_bilety" },
            { "Спорт, Активный отдых", "/all_sport" },
            { "Книги и журналы", "/all_knigi" },
            { "Коллекции", "/all_kollekcii" },
            { "Музыкальные инструменты", "/all_muzika" }
        };

        public Dictionary<string, string> oborudovanie { get; } = new Dictionary<string, string>
        {
            { "Газовое, топливное", "/all_gazovoe" },
            { "Деревообрабатывающее", "/all_derevo" },
            { "Железнодорожное", "h/all_gelezndor" },
            { "Инструменты", "/all_instrument" },
            { "Пищевое, с/х", "/all_selhoz" },
            { "Станки", "/all_stanok" },
            { "Торговое", "/all_torgovoe" },
            { "Электротехническое", "/all_elektro" },
            { "Другое", "/all_oborudmore" }
        };

        public Dictionary<string, string> syriyo { get; } = new Dictionary<string, string>
        {
            { "Пиломатериалы", "/all_pilom" },
            { "Металлы", "/all_metal" },
            { "Нефть, газ, топливо", "/all_toplivo" },
            { "Химия", "/all_himiya" },
            { "Бумага, тара, упаковка", "/all_bumaga" },
            { "Другое", "/all_rawmore" }
        };

        public Dictionary<string, string> stroytovari { get; } = new Dictionary<string, string>
        {
            { "Конструкции", "/all_konst" },
            { "Материалы", "/all_material" },
            { "Сантехника", "/all_santehnika" },
            { "Механизмы", "/all_mehanizm" },
            { "Производство работ", "/all_proizrabot" },
            { "Другое", "/all_stroitelmore" }
        };

        public Dictionary<string, string> produkti { get; } = new Dictionary<string, string>
        {
            { "Зерно, крупы", "/all_zerno" },
            { "Кондитерские изделия", "/all_konditer" },
            { "Консервы", "/all_konserv" },
            { "Мясо, колбасы", "/all_myaso" },
            { "Рыба, морепродукты", "/all_fish" },
            { "Соки, воды", "/all_soki" },
            { "Другие продукты", "/all_produktmore" }
        };

    }
}
