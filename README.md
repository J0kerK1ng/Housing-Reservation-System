# Housing-Reservation-System
This app was followed by a MVC course that help me understand how it works.
This is a good model for Create, Edit, Delete Category. 
This project only has modify category right now, I will try do add more code to this project.
######################################################################################################
GNU General Public License v3.0
Like the GPL v2, GPL 3 is a strong copyleft license, meaning that any copy or modification of the original code must also be released under the GPL v3. In other words, you can take the GPL 3’d code, add to it or make major changes, then distribute your version.

Overview
The Housing Reservation System is a robust and user-friendly platform that enables users to search, reserve, and manage housing properties efficiently. This project aims to streamline the reservation process and provide an intuitive interface for property owners and potential renters.

Features
User registration and authentication
Comprehensive property search and filtering
Reservation management
Property owner dashboard for listing and managing properties
Email notifications for booking confirmations and updates
Calendar integration for availability tracking
Secure payment processing
Installation
Prerequisites
Python 3.x
Django 3.x
PostgreSQL
Setup
Clone the repository:


git clone https://github.com/J0kerK1ng/Housing-Reservation-System.git
Create a virtual environment:


python -m venv venv
Activate the virtual environment:
On Windows:
bash
Copy code
.\venv\Scripts\activate
On macOS and Linux:

source venv/bin/activate
Install the required packages:


pip install -r requirements.txt
Configure your PostgreSQL database in settings.py:
python
Copy code
DATABASES = {
    'default': {
        'ENGINE': 'django.db.backends.postgresql',
        'NAME': 'your_db_name',
        'USER': 'your_db_user',
        'PASSWORD': 'your_db_password',
        'HOST': 'localhost',
        'PORT': '5432',
    }
}
Run database migrations:


python manage.py makemigrations
python manage.py migrate
Create a superuser:

python manage.py createsuperuser
Run the development server:


python manage.py runserver
Access the application at http://127.0.0.1:8000/
Usage
Register as a new user or log in as an existing user.
Browse available properties and use the search and filtering options to narrow down your selection.
Reserve a property by selecting the desired dates and completing the payment process.
Property owners can list and manage their properties through the owner dashboard.
Both renters and property owners can manage their reservations and receive email notifications for updates.
Contributing
Please feel free to fork the repository and submit pull requests for new features, bug fixes, or improvements. If you have any questions or suggestions, feel free to open an issue.

License
This project is licensed under the MIT License. See the LICENSE file for details.

..........

