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

#### 2. Appoitment History:

Here, the patient can see their appointment history which contains Doctor Name, Appointment Date and Time. Additionally, the patient can rate the doctor.(See Fig 1.7).

![PatientAppoitmentHistory](https://github.com/turanemircan/HospitalManagementSystem/assets/115572710/6e95f661-d655-4c56-8bb8-2ecd67b3265b) Fig 1.7

This is how the patient module works. On the whole, this module allows patients to register their account or login their account(if he/she has one), book an appointment and view his/her appointment history.

### 3. Information
Users can update their personal information in this section.(Fig 1.8) They can also update their password from the password change screen.(Fig 1.9)

![Information](https://github.com/turanemircan/HospitalManagementSystem/assets/115572710/d4eedbc1-f95c-4baf-a50b-e2869a4ca410) Fig 1.8

![İnformationPassword](https://github.com/turanemircan/HospitalManagementSystem/assets/115572710/4601bf5a-e454-465c-9c11-5d1aea23099a) Fig 1.9

### Doctor Module
The doctors can login into their account which can be done by toggling the tab from ‘Patient’ to ‘Doctor’. Fig 1.10 shows the login form for a doctor. Registration of a doctor account can be done only by admin. We will discuss more about this in Admin Module. I will not mention it again since it is the same for both the Doctor and Secretary sections.

![DoctorSecretaryAdminLogin](https://github.com/turanemircan/HospitalManagementSystem/assets/115572710/d87989a2-8995-4965-a74d-410c8b92344f) Fig 1.10

Once the doctor clicking the ‘Login’ button, they will be redirected to their own dashboard which is shown in Fig 1.11

![DoctorMenu](https://github.com/turanemircan/HospitalManagementSystem/assets/115572710/c744009d-fb80-48b2-8b7e-ee473992cc51) Fig 1.11

#### 1. View Appoitment:

In this page, doctor can able to see their appointments which has been booked by the patients.(Fig 1.12)

![DoctorViewAppointment](https://github.com/turanemircan/HospitalManagementSystem/assets/115572710/5d3ed9fa-f1ea-4726-beda-cd489c845b26) Fig 1.12

