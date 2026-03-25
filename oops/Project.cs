//“I worked on a Client Profile Management System for financial advisors.
//The goal was to help advisors store, manage, and track their clients’ complete financial profiles, including nominees, liabilities, investments, and family information.
//The system provided a centralized dashboard to view all client data securely, generate reports, and make informed decisions.”

//2️⃣ Key Features (1 min)
//Client Information: Name, contact, demographic details
//Nominee Details: Name, relation, share %
//Financial Liabilities: Loans, credit, EMIs
//Investments: Mutual funds, stocks, gold, bonds
//Family Details: Spouse, children, dependents
//Secure Access: Role - based access for financial advisors

//“We implemented CRUD operations, so advisors could add, update, delete, and view client profiles efficiently.”

//3️⃣ Technical Stack & Architecture (40 sec)
//Backend: ASP.NET Core Web API
//Frontend: Angular
//Database: SQL Server(normalized tables for Clients, Nominees, Investments, Family)
//Caching: MemoryCache for frequently accessed client lists
//Routing & Performance: Implemented pagination, async API methods, and output caching for repeated requests
//Security: Role - based authorization

//“We designed the system as layered architecture, separating Controllers, Services, and Repositories for maintainability.”

//4️⃣ OOP Concepts(1 min)
//Abstraction:
//Created abstract classes for ClientBase and FinancialEntity
//Exposed only necessary methods like GetProfile() or CalculateTotalLiabilities()
//Polymorphism:
//Implemented overloaded methods for calculating liabilities for individual vs family clients
//Overridden methods for different types of investments(mutual funds, stocks, gold)
//// Abstraction
//public abstract class ClientBase
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public abstract decimal CalculateNetWorth();
//}

//// Polymorphism
//public class IndividualClient : ClientBase
//{
//    public override decimal CalculateNetWorth() => Investments.Sum(i => i.Value) - Liabilities.Sum(l => l.Amount);
//}

//public class FamilyClient : ClientBase
//{
//    public override decimal CalculateNetWorth() => Investments.Sum(i => i.Value) - Liabilities.Sum(l => l.Amount) - DependentExpenses;
//}