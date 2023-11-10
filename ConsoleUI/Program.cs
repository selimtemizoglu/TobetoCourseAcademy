
using Business.Concretes;
using Entities.Concretes;

Category category = new Category();
category.Id = 1;
category.Name = "Programlama";

CategoryManager categoryManager = new CategoryManager();
categoryManager.Add(category);


Camp camp = new Camp();
camp.ProgrammingLanguages = "Camp";
camp.Level = 1;
camp.Homework = "Değişkenleri çalışınız.";


CampManager campManager = new CampManager();
campManager.Add(camp);