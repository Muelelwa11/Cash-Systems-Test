# Cash-Systems-Test
Cash Systems for Deposita Cash Operations - It allows users to manage banking transactions.

# Deposita Cash Operations Starter Projects

## Backend (.NET Core Web API)

### Setup

1. Make sure you have .NET 6 SDK installed.
2. Update connection string in `appsettings.json` if needed.
3. Run migrations or use the provided SQL script to create the database.
4. Run the API:
```bash
cd Deposita.API
dotnet restore
dotnet run
```
API will run at `https://localhost:5001`.

---

## Frontend (Angular)

### Setup

1. Make sure you have Node.js and Angular CLI installed.
2. Navigate to frontend folder:
```bash
cd deposita-ui
npm install
ng serve
```
App will run at `http://localhost:4200`.

---

## Database

Use the provided `BankingDB.sql` script to create and seed the database.

---

## Notes

- API base URL in Angular service is set to `https://localhost:5001/api/transaction`.
- Adjust ports and URLs if needed.
- Use Angular Material and reactive forms to build UI components further.
