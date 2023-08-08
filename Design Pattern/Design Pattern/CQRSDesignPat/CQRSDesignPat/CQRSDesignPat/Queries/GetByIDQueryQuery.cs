namespace CQRSDesignPat.CQRSDesignPat.Queries
{
    public class GetByIDQueryQuery
    {
        public GetByIDQueryQuery(int ıD)
        {
            ID = ıD;
        }

        public int ID { get; set; }
        //Burası Dapper / Ado.Net sorgusuda alabilir.
    }
}
