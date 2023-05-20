namespace DomainModel
{
    public static class CurrentSession
    {
        public static object Account { get; set; } = new Guest(); //Person object
        public static bool IsAdmin { get; set; } = false; //
        public static object? ViewInstance; //Views user control object

        public static int ChangePassTabPageIndex = -1;
        public static int RegTabPageIndex = -1;
        public static int AccountTabPageIndex = -1;
        public static int CreateTourTabPageIndex = -1;
        public static int TourTabPageIndex = -1;
        public static int AdminTabPageIndex = -1;

    }
}
