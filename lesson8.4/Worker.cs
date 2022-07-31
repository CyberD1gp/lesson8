namespace lesson8._4
{
    public class Worker
    {
        #region Поля

        /// <summary>
        /// Поле "ФИО"
        /// </summary>
        private string person;

        /// <summary>
        /// Поле "Улица"
        /// </summary>
        private string street;

        /// <summary>
        /// Поле "Номер дома"
        /// </summary>
        private int houseNumber;

        /// <summary>
        /// Поле "Номер квартиры"
        /// </summary>
        private int flatNumber;

        /// <summary>
        /// Поле "Мобильный телефон"
        /// </summary>
        private int mobilePhone;

        /// <summary>
        /// Поле "Домашний телефон"
        /// </summary>
        private int flatPhone;



        #endregion

        #region Свойства
        /// <summary>
        /// ФИО
        /// </summary>
        public string Person { get { return person; } set { person = value; } }

        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get { return street; } set { street = value; } }

        /// <summary>
        /// Номер дома
        /// </summary>
        public int HouseNumber { get { return houseNumber; } set { houseNumber = value; } }

        /// <summary>
        /// Номер квартиры
        /// </summary>        
        public int FlatNumber { get { return flatNumber; } set { flatNumber = value; } }

        /// <summary>
        /// Мобильный телефон
        /// </summary>
        public int MobilePhone { get { return mobilePhone; } set { mobilePhone = value; } }

        /// <summary>
        /// Домашний телефон
        /// </summary>
        public int FlatPhone { get { return flatPhone; } set { flatPhone = value; } }
        #endregion

        #region Конструктор

        public Worker()
        {

        }
        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="Person">ФИО</param>
        /// <param name="Street">Улица</param>
        /// <param name="HouseNumber">Номер дома</param>
        /// <param name="FlatNumber">Номер квартиры</param>
        /// <param name="MobilePhone">Мобильный телефон</param>
        /// <param name="FLatPhone">Домашний телефон</param>
        
        public Worker(string Person,string Street,int HouseNumber,int FlatNumber,int MobilePhone,int FLatPhone)
        {
            this.Person = Person;
            this.Street = Street;
            this.HouseNumber = HouseNumber;
            this.FlatNumber = FlatNumber;
            this.MobilePhone = MobilePhone;
            this.FlatPhone = FLatPhone;


        }

        #endregion

      

    }
}
