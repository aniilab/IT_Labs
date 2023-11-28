using MyDBSM.Controllers;
using MyDBSM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDBSMTests
{
    public class ProjectionTests
    {
        [Fact]
        public void ProjectionTest()
        {
            //Arrange
            Database db = new Database("testDatabase");
            Table table = new Table("Students");
            Column nameColumn = new StringColumn("Name", false);
            Column ageColumn = new IntColumn("Age", false);
            Column favoriteColorColumn = new ColorColumn("FavoriteColor", true);
            Row testRow = new Row(1)
            {
                Values = new List<string> { "Alina", "20", "#000000" }
            };
            db.Tables.Add(table);
            db.Tables[0].Columns.Add(nameColumn);
            db.Tables[0].Columns.Add(ageColumn);
            db.Tables[0].Columns.Add(favoriteColorColumn);
            db.Tables[0].Rows.Add(testRow);
            Dictionary<int, string> indexNameColumns = new Dictionary<int, string>();
            indexNameColumns[0] = "Name";
            indexNameColumns[2] = "FavoriteColor";
            var expectedResult = new Table("ProjectedTable")
            {
                Columns = new List<Column> { nameColumn, favoriteColorColumn },
                Rows = new List<Row>
                {
                    new Row(0) { Values = new List<string> { "Alina", "#000000" } }
                }
            };

            //Act
            DBController.db = db;
            var result = DBController.ProjectTable(0, indexNameColumns);

            //Assert
            Assert.Equal(result.Columns[0], expectedResult.Columns[0]);
            Assert.Equal(result.Columns[1], expectedResult.Columns[1]);
            Assert.Equal(result.Rows[0].Values[0], expectedResult.Rows[0].Values[0]);
            Assert.Equal(result.Rows[0].Values[1], expectedResult.Rows[0].Values[1]);


        }
    }




}
    
