﻿using System;
using Microsoft.Maui.Controls;
using TaskManager;

namespace TaskManager
{
    public partial class TodoItemPage : ContentPage
    {
        private readonly TodoItemDatabase _database;
        public TodoItem Item { get; set; }

        public TodoItemPage(TodoItemDatabase todoItemDatabase)
        {
            InitializeComponent();
            _database = todoItemDatabase;

            // Create a new item or initialize it from navigation parameters
            Item = new TodoItem();
            BindingContext = Item; // Bind UI elements to the Item
        }

        // Event handler for the Save button
        async void OnSaveClicked(object sender, EventArgs e)
        {
            // Validate the item name
            if (string.IsNullOrWhiteSpace(Item.Name))
            {
                await DisplayAlert("Name Required", "Please enter a name for the to-do item.", "OK");
                return;
            }

            // Save the item to the database
            await _database.SaveItemAsync(Item);

            // Navigate back to the previous page
            await Shell.Current.GoToAsync("..");
        }

        // Additional event handlers (if needed)
        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}