using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class fffff
    {
        public List<Quetion> ListOfAsk { get; set; }
        public fffff()
        {
            ListOfAsk = new List<Quetion>()
          {
              new Quetion ("Какая страна считается рекордсменом по количеству проживающих в ней кошек?", new List<Option>()
              {
                new Option("США","США по праву может считаться \"кошачьим Китаем\". Количество мурчащих жителей здесь составляет 76,5 миллионов. В среденем в каждой третьей семье живет по 2 кошки.", true),
                new Option("Китай", null, false),
                new Option ("Россия", null, false),
                new Option ("Греция", null, false),
              }
              ),
              new Quetion ("Почему кошки так любят валерьянку", new List<Option>()
              {
                new Option("Это сильный аттрактант","этот хитрый вопрос содержит сразу два правильных ответа!", true),
                new Option("содержит кошачьи феромоны", null, false),
                new Option ("нравится запах", null, false),
                new Option ("повышает аппетит","этот хитрый вопрос содержит сразу два правильных ответа!", true),
              }),
              new Quetion ("Как вы думаете, в рождении скольких котят поучаствовал Дасти из Техаса, рекордсмен среди кошачьих отцов?", new List<Option>()
              {
                new Option("150 котят",null, false),
                new Option("360 котят", null, false),
                new Option ("420 котят", "В это сложно поверить, но пушистый Казанова - отец 420 котят!", true),
                new Option ("500 котят", null, false),
              }),
              new Quetion ("Какая самая дорогая порода собак", new List<Option>()
              {
                new Option("лион бишон",null, false),
                new Option("фараонова собака", null, false),
                new Option ("тибетский мастиф", "Приготовьте 8 тысяч долларов, если хотите похвастаться красавчиком тибетским мастифом, представителем самой дорогой породы собак в мире!", true),
                new Option ("500 котят", null, false),
              }),
          };
        }
        public List<Quetion> ListQuestion()
        {
            return ListOfAsk;
        }
    }
}
