using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

/*
* File name: RegistrationPage.cs
* 
* @description This class exists to render the registration page that appears when the user attempts to login for the first time. 
*              
* 
* @author Michael Miller
* @email miller.7594@osu.edu
* @version 03/18/2017
* 
*/

namespace CAPLab
{
    class RegistrationPage : ContentPage
    {
        Entry firstNameField, lastNameField, osuUsernameField, surveyConditionField;
        Label registrationErrorMesage;

        public RegistrationPage()
        {
            this.registrationErrorMesage = new Label { Text = string.Empty };
            firstNameField = new Entry
            {
                Placeholder = "First Name"
            };
            lastNameField = new Entry
            {
                Placeholder = "Last Name"
            };

            osuUsernameField = new Entry
            {
                Placeholder = "OSU name.#",
                Keyboard = Keyboard.Plain
            };
            Label surveyConditionLabel = new Label
            {
                Text = "Enter the code supplied by OSU CAPLab below:"
            };
            surveyConditionField = new Entry
            {
                Placeholder = "2017-0001-0001-0001",
                Keyboard = Keyboard.Telephone
            };

            var doneButton = new Button
            {
                Text = "Done?"
            };

            doneButton.Clicked += OnDoneButtonClicked;

            Content = new StackLayout
            {
                Children =
                {
                    firstNameField,
                    lastNameField,
                    osuUsernameField,
                    surveyConditionLabel,
                    surveyConditionField,
                    registrationErrorMesage,
                    doneButton
                }
            };
        }

        void OnDoneButtonClicked (object sender, EventArgs e)
        {
            if (firstNameField.Text != null && lastNameField.Text != null && osuUsernameField.Text != null && surveyConditionField.Text != null)
            {
                bool firstNameValid = firstNameField.Text.Length > 0 && !Regex.IsMatch(firstNameField.Text, @"\d");
                bool lastNameValid = lastNameField.Text.Length > 0 && !Regex.IsMatch(lastNameField.Text, @"\d");
                bool osuUsernameValid = osuUsernameField.Text.Length > 0 && Regex.IsMatch(osuUsernameField.Text, @"(\w+[A-Za-z]\.[0-9]\w+)");
                bool surveyConditionValid = surveyConditionField.Text.Length > 0 && Regex.IsMatch(surveyConditionField.Text, @"(\d{4}\-\d{4}\-\d{4}\-\d{4})");
                if (firstNameValid && lastNameValid && osuUsernameValid && surveyConditionValid)
                {
                    User user = new User
                    {
                        firstName = firstNameField.Text,
                        lastName = lastNameField.Text,
                        osuUsername = osuUsernameField.Text,
                        surveyCondition = surveyConditionField.Text
                    };

                    Navigation.InsertPageBefore(new InitialSetupPage(user), this);
                    Navigation.PopAsync();
                }
                else
                {
                    if (!firstNameValid)
                    {
                        registrationErrorMesage.Text = "Registration failed. Invalid first name.";
                    }
                    else if (!lastNameValid)
                    {
                        registrationErrorMesage.Text = "Registration failed. Invalid last name.";
                    }
                    else if (!osuUsernameValid)
                    {
                        registrationErrorMesage.Text = "Registration failed. Invalid username format.";
                    }
                    else if (!surveyConditionValid)
                    {
                        registrationErrorMesage.Text = "Registration failed. Invalid survey condition format. Don't forget the dashes.";
                    }
                    else
                    {
                        registrationErrorMesage.Text = "Registration failed. Unknown reason.";
                    }
                }

            }
            else
            {
                registrationErrorMesage.Text = "Registration fields cannot be blank.";
            }


        }
    }
}
