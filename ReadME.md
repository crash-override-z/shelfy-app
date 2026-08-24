# ShelfyBackend - Sushi Order System

A robust C# console application featuring a multi-item cart system, input validation loops, a unique UUID ticket generator, an admin revenue dashboard, and a persistent CSV backend data store.

---

## Architecture & Data Flow

<details>
<summary><b>🔍 Click here to view system architecture & data flow JSON</b></summary>

```json
{
  "ProgramClassBox": {
    "Engine": "static void Main(string[] args)",
    "VariablesBox": [
      "List<CartItem> cart",
      "username",
      "pickupDay",
      "pickupTime",
      "grandTotal",
      "ticketNumber"
    ],
    "ValidationLoopsBox": [
      "while (rollType == \"\")",
      "while (pickupDay == \"\")",
      "while (!isValidTime)"
    ],
    "DataFlowPipeline": "User Keyboard -> Console.ReadLine -> List<CartItem> -> Guid.NewGuid -> File.AppendAllText -> orders.csv"
  }
}

================================================================================
                              PROGRAM CLASS BOX
================================================================================
[ class Program & CartItem ]
 └── [ static void Main(string[] args) ] ──> The main execution engine
        │
        ├────────────────────────────────────────────────────────┐
        │                                                        │
        ▼                                                        ▼
┌───────────────────────────────┐                ┌───────────────────────────────┐
│         VARIABLES BOX         │                │     VALIDATION LOOPS BOX      │
│  (Labeled containers in RAM)  │                │   (Catches bad typing live)   │
├───────────────────────────────┤                ├───────────────────────────────┤
│ • List<CartItem> cart         │                │ • while(rollType == "")       │
│ • string username             │                │ • while(pickupDay == "")      │
│ • string pickupDay            │                │ • while(!isValidTime)         │
│ • string pickupTime           │                │                               │
│ • double grandTotal           │                │  *Forces user to re-type until│
│ • string ticketNumber         │                │   input matches rule set.*    │
└──────────────┬────────────────┘                └──────────────┬────────────────┘
               │                                                │
               └───────────────────────┬────────────────────────┘
                                       │
                                       ▼
================================================================================
                              DATA FLOW PIPELINE
================================================================================

 [ USER KEYBOARD ] 
        │
        ▼
 (Console.ReadLine) ──> Populates Cart and Variables (`rollChoice`, `qty`, etc.)
        │
        ▼
 (Financial Calc)  ──> Computes Subtotal + $1.50 Fee + 5% GST = `grandTotal`
        │
        ▼
 (Guid.NewGuid)    ──> Generates a secure random code (`ticketNumber`)
        │
        ▼
 (String Assembly) ──> Glues order data into CSV format:
                       "josh,C1D623,\"2x Fujiya Roll + 1x Tuna Maki\",friday,12:00,32.50"
        │
        ▼
 (File.AppendAllText) 
        │
        ▼
┌──────────────────────────────────────────────────────────────┐
│                  BACK-END HARD DRIVE STORAGE                 │
│                          orders.csv                          │
│  Line 1: [matchaman josh] , [C0B961] , [2x Spicy Tuna] , ... │
│  Line 2: [eric koston]    , [645636] , [1x Spicy Tuna] , ... │
└──────────────────────────────────────────────────────────────┘

