using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForGods
{
   public class LoadAsk
    {
        private List<Question> ListOfAsk { get; set; }
        public LoadAsk()
        {
            ListOfAsk = new List<TestForGods.Question>()
          {
              new Question ("Какая страна считается рекордсменом по количеству проживающих в ней кошек?", new List<TestForGods.Option>()
              {
                new TestForGods.Option("США","США по праву может считаться \"кошачьим Китаем\". Количество мурчащих жителей здесь составляет 76,5 миллионов. В среденем в каждой третьей семье живет по 2 кошки.", true),
                new Option("Китай", null, false),
                new Option ("Россия", null, false),
                new Option ("Греция", null, false),
              }
              ),
              new Question ("Почему кошки так любят валерьянку?", new List<TestForGods.Option>()
              {
                new TestForGods.Option("Это сильный аттрактант","этот хитрый вопрос содержит сразу два правильных ответа!", true),
                new Option("содержит кошачьи феромоны", null, false),
                new Option ("нравится запах", null, false),
                new Option ("повышает аппетит","этот хитрый вопрос содержит сразу два правильных ответа!", true),
              }),
              new Question ("Как вы думаете, в рождении скольких котят поучаствовал Дасти из Техаса, рекордсмен среди кошачьих отцов?", new List<TestForGods.Option>()
              {
                new TestForGods.Option("150 котят",null, false),
                new Option("360 котят", null, false),
                new Option ("420 котят", "В это сложно поверить, но пушистый Казанова - отец 420 котят!", true),
                new Option ("500 котят", null, false),
              }),
              new Question ("Какая самая дорогая порода собак?", new List<TestForGods.Option>()
              {
                new TestForGods.Option("лион бишон",null, false),
                new Option("фараонова собака", null, false),
                new Option ("тибетский мастиф", "Приготовьте 8 тысяч долларов, если хотите похвастаться красавчиком тибетским мастифом, представителем самой дорогой породы собак в мире!", true),
                new Option ("аффенпинчер", null, false),
              }),
              new Question ("В какой стране черная кошка, перебежавшая вам дорогу, считается хорошей приметой?", new List<TestForGods.Option>()
              {
                new TestForGods.Option("Чили",null, false),
                new Option("Китай", null, false),
                new Option ("Великобритания", "В Великобритании черная кошка считается символом удачи. Британцы верят, черный кот дарит богатсво и процветание", true),
                new Option ("Швеция", null, false),
              }),
              new Question ("Как называется станция в Японии, на которой установлен знаменитый памятник самому верному псу Хатико?", new List<TestForGods.Option>()
              {
                new TestForGods.Option("Намбоку",null, false),
                new Option ("Асакуса", null, false),
                new Option("Сибуя", "Станция Хатико стоит на станции Сибуя и является местом втречи многих влюбленных.", true),
                new Option ("Синдзюку", null, false),
              }),
              new Question ("Какой фильм про братьев наших меньших пока еще не сняли?", new List<TestForGods.Option>()
              {
                new TestForGods.Option("Отель для собак",null, false),
                new Option ("Хостел для котов", "\"Хостел для котов\" - название известной американской комедии про хвостатых. Но возможно скоро мы увидим вторую часть уже с другими героями...", true),
                new Option("Кошки против собак", null, false),
                new Option ("Снежные псы", null, false),
              }),
              new Question ("Хаски по кличке Барни - настоящий непоседа. Хозяева гуляют с ним по 3-4 часа в день и часто берут с собой в походы. Какой корм оптимально подойдет Барни?", new List<TestForGods.Option>()
              {
                new TestForGods.Option("PRO PLAN® ALL SIZES ADULT PERFORMANCE","Идеален для собак с активным образом жизни, часто бывающих на открытом воздухе, - например, в горах или даже просто в парке", true),
                new Option ("PRO PLAN® ALL SIZES ADULT PERFORMANCE",null, true),
                new Option("PRO PLAN® ALL SIZES ADULT PERFORMANCE", null, true),
                new Option ("PRO PLAN® ALL SIZES ADULT PERFORMANCE", null, true),
              })
              ,
              new Question ("Персик, крсавец лабрадор, недавно перенес операцию по кастрации. Какой корм рекомендуется добавить в рацион питомцу?", new List<TestForGods.Option>()
              {
                new TestForGods.Option("PRO PLAN® ALL SIZES ADULT LIGHT/STERILISED","подходит для стерилизованных собак всех пород", true),
                new Option ("PRO PLAN® SMALL & MINI PUPPY c комплексом OPTISTART®",null, false),
                new Option("PRO PLAN® ALL SIZES ADULT PERFORMANCE", null, false),
                new Option ("PURINA® DOG CHOW", null, false),
              })
              ,
              new Question ("Мейн-кун Сири покорил своих хозяев добротой и красивой, гладкой, длинной шерсткой. Какой корм поможет хозяевам поддерживать природную красоту и ухоженность их питомца?", new List<TestForGods.Option>()
              {
                new TestForGods.Option("PRO PLAN® Sterilised",null, false),
                new Option ("PRO PLAN® Derma Plus","Абсолютно верно! Серия Derma Plus поддерживает здоровье кожи и природную красоту шерсти, а также снижает образование комков шерсти в желудке", true),
                new Option("PRO PLAN® Delicate", null, false),
                new Option ("PRO PLAN® Adult", null, false),
              })
          };
        }
        public List<Question> GetListQuestion()
        {
            return ListOfAsk; 
        }
    }
}
