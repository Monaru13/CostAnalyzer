﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using CostAnalyzer.Models;
using CostAnalyzer.Services;

namespace CostAnalyzer.ViewModels
{
    public class CostListViewModel : ViewModelBase
    {
        private readonly CostItemsRepository _repository;
        
        public CostListViewModel(CostItemsRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<CostItem> Items => _repository.GetItems();
    }
}