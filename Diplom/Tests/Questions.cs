using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{

    public enum CategoryQuest
    {
        /// <summary>
        /// Задание с открытым ответом!
        /// </summary>
        Category_1,
        /// <summary>
        /// Задание с выбором ответа!
        /// </summary>
        Category_2,
        /// <summary>
        /// Задание на упорядочивание последовательности!
        /// </summary>
        Category_3,
        /// <summary>
        /// Задание на устоновление соответствия!
        /// </summary>
        Category_4
    }
    class Questions
    {
        public CategoryQuest CategoryObj { get; set; }
        public int Index { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Image { get; set; }
        public string image1 { get; set; }
    }
}
