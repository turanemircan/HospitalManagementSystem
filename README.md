# Hospital Management System

Hospital Management System using MSSQL, C# and Windows Forms.

This project works on a hospital management system. The purpose of the system is to manage the information of hospital staff and patients, schedule appointments, and maintain medical records.

## Getting Into The Application
### Main Menu

This system has a ‘Home’ page from where the patient, doctor & administrator can login into their accounts by toggling the tabs accordingly. Fig 1.1 shows the ‘Home’ page of our project.

![MainMenu](https://github.com/turanemircan/HospitalManagementSystem/assets/115572710/ae22ef39-bf75-4cc9-a0ac-da466fa2c247) Fig 1.1

The ‘Home’ page consists of 4 modules:

1. Patient Module
2. Doctor Module
3. Secretary Module
4. Admin Module

### Patient Module
This module allows patients to create their account, book an appointment to see a doctor and see their appointment history. The registration page(Fig 1.3) asks patients to enter their First Name, Last Name, Contact Number, Password.
Users can log in to their accounts. Fig 1.2 illustrates the login page. Upon clicking the 'Login' button, patients will be redirected to their dashboard page.

![PatientLogin](https://github.com/turanemircan/HospitalManagementSystem/assets/115572710/9c6337b7-463f-4f7b-a81e-0b5390bfc838) Fig 1.2
![PatientRegister](https://github.com/turanemircan/HospitalManagementSystem/assets/115572710/98ce79d5-1a6c-4ef7-9b4c-7e41436a2274) Fig 1.3

Once the patient has created his/her own account after clicking the ‘Register’ button, then he will be redirected to his/her Dashboard(Fig 1.4).

![PatientMenu](https://github.com/turanemircan/HospitalManagementSystem/assets/115572710/89f97a40-d0a5-456e-9879-835221a1203b) Fig 1.4

The Dashboard page allows patients to perform three operations:

#### 1. Make an Appoitment:

Here, the patients can able to book their appointments to see a doctor. The appointment form(Fig 1.4) requires patients to select the doctor that they want to see, Date and Time that they want to meet with the doctor.

After clicking on the ‘Create new entry’ button, the patient will receive an alert that acknowledges the successful appointment of the patient.(See Fig 1.5)

![PatientAppoitmentSuccess](https://github.com/turanemircan/HospitalManagementSystem/assets/115572710/fe6465a4-a59b-46cb-b86d-bc181be2a106) Fig 1.5

If the appointment time is already booked, it will display a warning.(See Fig 1.6)

![PatientAppoitmentError](https://github.com/turanemircan/HospitalManagementSystem/assets/115572710/dc65afb9-90ef-4df0-b917-0902d94c73fa) Fig 1.6

#### 1. Appoitment History:

