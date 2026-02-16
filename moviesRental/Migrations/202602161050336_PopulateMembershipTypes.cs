namespace moviesRental.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipType (Id, SignUpFee, DurationInMonths, DiscountRate) VAlUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipType (Id, SignUpFee, DurationInMonths, DiscountRate) VAlUES (2, 20, 1, 10)");
            Sql("INSERT INTO MembershipType (Id, SignUpFee, DurationInMonths, DiscountRate) VAlUES (3, 90, 3, 15)");
            Sql("INSERT INTO MembershipType (Id, SignUpFee, DurationInMonths, DiscountRate) VAlUES (4, 300, 12, 20)");
        }

        public override void Down()
        {
        }
    }
}
