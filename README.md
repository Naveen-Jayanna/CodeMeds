# CodeMeds
In India, the problem of adulteration and the entry of fake medications into the pharmaceutical market is getting worse. According to official WHO figures, India accounts for roughly 35% of all imported counterfeit medications in the globe, creating a drug mafia market worth INR 40,000,000,000. The primary cause is that every step of the rigorous process in the current system requires human interaction. Human error will inevitably result from this, which is exploited. The primary and most significant flaw in the currently in place system is the lack of an automated mechanism. The project suggests an automated method that creates machine-readable code for each entity to serve as a unique recognition mechanism. This generation of the machine-readable code is backed up the encryption and hashing and hence cannot be replicated by a third party.

# Introduction
Lack of a strict mechanism in the pharmaceutical sector to check the legitimacy of the medication and human involvement at every stage are factors contributing to a growth in fake medications. This issue's elimination is thought to be the main concern, and it's important to make sure that the meta data associated with each individual drug's leaflet is displayed to ensure clarity and combat adulteration and counterfeit medication. The meta data shows the date of manufacture, the date of expiration, the ingredients used, the price, and more. This project suggests a controlled and secure method by:
- creating machine-readable code for each leaflet.
- Recognize each leaflet individually.
- A mobile app to access the leaflet's saved information.
- Building a meta data storage and retrieval system on the cloud.

# Existing System
Keeping the exisiting problem in mind and evaluating the present implemented solution which induces alot of human error and risking the authenticity of the medicine in the market leading to the endangerment of livestock. In the current system, humans are involved in every step of the process, from the manufacturing of the medication at each organization's certified manufacturing facilities to the transportation of the packaged medication to the pharmacy. The lack of secure mechanisms is caused by the human involvement at every stage, and human-induced errors are unavoidable. This then causes adulteration and the introduction of fake medication into the system. This approach falls short of giving customers a sense of assurance when it comes to their health and safety, which increases the need for an authenticated process.

# Proposed System
Introduction of machine-readable code that contains the meta data information the end user needs. Additionally, this system offers an automated system that is built without human involvement and offers security, transparency, and is more practical (cheap, less time-consuming, and trustworthy). Any actors in the system are given with interdependency, making the described system intrinsically more safe. Create and manage the created drug using an easy-to-use user interface. The Android application is integrated such that the data is very accessible to even inexperienced end users. This paper's major goal is to develop a safe and secure technique to lessen malfunctions in the pharmaceutical sector.

# Tech Stack
- ASP.NET
- SQLyog
- Java
- AWS
- Apache Tomcat
- Android

# ER Diagram

![Codemeds_ER_diagram](https://user-images.githubusercontent.com/52947925/211376369-6ce91180-090f-40be-9034-1ad9effa0295.png)

# Design

![Design](https://user-images.githubusercontent.com/52947925/211376451-7b63ef3c-3c28-44da-88f4-8acd6e02e038.JPG)

## Android application flowchart

![Flow1_app](https://user-images.githubusercontent.com/52947925/211373085-63add9d3-7c58-4fb5-a178-080c3003481c.png)

![Flow2_app](https://user-images.githubusercontent.com/52947925/211373096-ee77f327-5669-4c1b-bcd6-f7336c6ccd54.png)

![Android_flow](https://user-images.githubusercontent.com/52947925/211373210-cfe096ab-509f-4bec-bfe5-2f70112ebd45.JPG)

Web application design

![web_app_design](https://user-images.githubusercontent.com/52947925/211373186-0af946e8-a43d-4baf-a34e-67a2ff47a4df.jpg)

# Implementation Screenshots
## Web implementation

- Landing Page

![Landing Page](https://user-images.githubusercontent.com/52947925/211373283-62ec3b3a-c58d-4b28-a2c3-9f031c5bb3a9.png)

- Database

![Database](https://user-images.githubusercontent.com/52947925/211373396-8c5bc244-3eea-4f07-9c3a-956658e8a121.png)

- Manufacturer

![Manufacturer](https://user-images.githubusercontent.com/52947925/211373464-a3f8673e-ad10-45ef-8561-31bdaf11e0ec.png)

![Manufacturer](https://user-images.githubusercontent.com/52947925/211373452-22593b89-22af-46e4-b9d3-7366cbc3346a.png)

- Pharmacy

![Pharmacy](https://user-images.githubusercontent.com/52947925/211373476-88cb5f9d-dc50-4ff1-84c3-72c36c2806b3.png)

- Warehouse

![Warehouse1](https://user-images.githubusercontent.com/52947925/211373491-822d735d-2901-48a9-8424-35394cb5b569.png)

![Warehouse2](https://user-images.githubusercontent.com/52947925/211373496-8e80ccb4-aa78-4dd7-b636-b99372e5ea88.png)

## Android implementation

# Conclusion
We'll sum up by saying that QR codes are rapidly gaining widespread favor. Every day, a growing number of people accept and utilize this technology. The fact that marketers increasingly employ QR codes to connect with mobile consumers is one of the factors contributing to the QR code's explosive growth. In order to make the end user independent, a safe and automated method must be developed to decrease the availability of fake medications on the market.

The suggested system's strength is the hashing, which enables a sense of security by concealing the original metadata from unauthorized users and uses the least amount of system resources. This project's limitation is related to the QR code's size being reduced below a certain threshold (tested value = 0.4 sq. cm). As the size of the QR code shrinks, so does the likelihood that it will be read because the two are inversely proportionate. This threshold value can be further lowered by improving the smartphone cameras' hardware.


# Future Scope
The approach will eventually be used to create bulk QR codes from a stream of continuous input originating from many sources, arriving at various speeds and carrying various forms of data (alpha-numerals, bytes, image, audio, etc). This Android application may be useful for storing and retrieving information about medicines, their metadata, and related data in either their original form or as a QR code. This information can be stored and retrieved using an app that is similar to the one that has been developed and scaled to meet the needs of the user. Sensitive information like medical reports and prescriptions can be exchanged between the entities in a secure manner by extending the concept of encryption to such data.

# Research Paper Certificate
![Certificate](https://user-images.githubusercontent.com/52947925/211374753-9600df17-a3dc-407e-b367-1ce1e8e167e4.jpg)

# Reference
- Fabio Bracci, Antonio Corradi, Luca Foschini, “Database Security Management for Healthcare SaaS in the Amazon AWS Cloud”, Dipartimento di Elettronica, Informatica e Sistemistica (DEIS) University of Bologna, Italy.
- Jill Patel, Ashish Bhat, Kunal Chavada “A Review Paper on QR Code Based Android App for Healthcare”, International Research Journal of Engineering and Technology (IRJET), Volume: 02 Issue: 07.
- Sibusisiwe Dube, Siqabukile Ndlovu, Thambo Nyathi, and Khulekani Sibanda “QR Code Based Patient Medical Health Records Transmission: Zimbabwean Case”, National University of Science and Technology, Bulawayo, Bulawayo Province, Zimbabwe.
- WHO reports - the spurious drug menace & remedy Shishir Kant Jain http://medind.nic.in/haa/t06/i1/haat07i1p29.pdf. 
- Overview of AWS concepts -https://docs.aws.amazon.com/whitepapers. 
- Cookbook. In Android Application Development Cookbook: 93 Recipes for Building Winning Apps. Indiana: John Wiley& Sons, Inc.
- Cloud computing bible https://arpitapatel.files.wordpress.com/2014/10/cloud-computing-bible1.pdf
- Implementing QR Code Technology in Medical Device Package Manu Chakravarthy Kittanakere Naagaraj. 
