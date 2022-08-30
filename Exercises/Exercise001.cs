using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
	public class User
	{
		public string UserName;
		public string OSVersion;
		public string OS;

		public User(string username, string osversion, string os)
		{
			UserName = username;
			OSVersion = osversion;
			OS = os;
		}
	}
	public class Exercise001
	{
		public string CapitalizeWord(string word)
		{
			String returnValue = "";
			if(word is null) {
				return null;
			} else {
				int strLen = word.Length;
			    if(strLen >= 1)
		    	returnValue = char.ToUpper(word[0]) + word.Substring(1);
			}
			return returnValue;
		}

		public string GenerateInitials(string firstName, string lastName)
		{
			String returnValue = "";
			returnValue = char.ToUpper(firstName[0])+"."+char.ToUpper(lastName[0]) ;
			return returnValue;
		}

		public double AddVat(double originalPrice, double vatRate)
		{
			var addVatValue = 0.0;
				
			if(vatRate > 0 && originalPrice > 0){
				addVatValue = originalPrice + (originalPrice * vatRate/100);
				if(addVatValue % 1 != 0) {
					addVatValue = Math.Round(addVatValue, 2,MidpointRounding.AwayFromZero);
				} 
			} else {
				if (originalPrice < 0) {
					throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
				} else if(vatRate < 0) {
					throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");
				} else if (vatRate == 0){
						addVatValue = originalPrice;
				} 
			}
			return addVatValue;
		}

		public string Reverse(string sentence)
		{
			if (sentence == null) {
				return null;
			} else{
				char[] array = sentence.ToCharArray();
				Array.Reverse(array);
				return new String(array);
			} 
		}

		public int CountLinuxUsers(List<User> users)
		{
			int count = 0;
			String strCheck = "Linux";
			if(users != null) {
				foreach(User indUser in users ){
					if(indUser.OS == strCheck) 
						count++;
				   
				}
			}
			return count;
		}
	}
}

