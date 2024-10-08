# Design Diagrams

## 1. ERD
**Entities**:
- **Employee**

**Attributes**:
- **EmployeeId**: VARCHAR(50)
- **EmployeeFirstName**: string (VARCHAR(100))
- **EmployeeLastName**: string (VARCHAR(100))
- **EmployeeDateOfBirth**: DateTime

![image](https://github.com/user-attachments/assets/0362914d-633e-4d6e-baf9-3c6326f2efd9)
  <!-- Replace with your image path -->

---

## 2. Class Diagram - Employee Model
**Class**:
- **Employee**

**Properties**:
- **EmployeeId**: string
- **EmployeeFirstName**: string
- **EmployeeLastName**: string
- **EmployeeDateOfBirth**: DateTime

![image](https://github.com/user-attachments/assets/21081814-83a6-4812-b937-f36bb5e421af)
  <!-- Replace with your image path -->

---

## 3. Class Diagram for DbContext
**Class**:
- **EmployeeContext**

**Relationships**:
- DbSet<Employee> (one-to-many relationship)

![image](https://github.com/user-attachments/assets/e640c8bf-c639-4897-a149-b84abbf719b6)
  <!-- Replace with your image path -->

---

## 4. Components Diagram for API Structure
**Components**:
- **EmployeeController**
- **EmployeeContext**
- **EmployeeModel**

**Relations**:
- **EmployeeController** → **EmployeeContext** (for CRUD operations)
- **EmployeeController** → **EmployeeModel** (to create and update models)

![image](https://github.com/user-attachments/assets/0b5e7ecb-afae-4982-a0b7-956cb6452148)
 <!-- Replace with your image path -->

---

## 5. Sequence Diagram for CRUD Operations
**Actors**:
- Client
- EmployeeController
- EmployeeContext

**Processes**:
- Create
- Read
- Update
- Delete

![image](https://github.com/user-attachments/assets/c00454b1-9b3c-495f-86d9-c1a60f72d895)
  <!-- Replace with your image path -->
