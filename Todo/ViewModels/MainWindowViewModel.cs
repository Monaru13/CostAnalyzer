﻿using System;
using System.Reactive.Linq;
using ReactiveUI;
using Todo.Models;
using Todo.Services;

namespace Todo.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        ViewModelBase content;

        public MainWindowViewModel(Database db)
        {
            Content = List = new CostListViewModel(db.GetItems());
        }

        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public CostListViewModel List { get; }

        public void AddItem()
        {
            var vm = new AddItemViewModel();

            Observable.Merge(
                vm.Ok,
                vm.Cancel.Select(_ => (CostItem)null))
                //.Take(1)
                .Subscribe(model =>
                {
                    if (model != null)
                    {
                        List.Items.Add(model);
                    }

                    Content = List;
                });

            Content = vm;
        }
    }
}