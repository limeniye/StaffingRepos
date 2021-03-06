﻿using Common;
using System.Collections.ObjectModel;

namespace Staffing.InterfacesVM
{
    /// <summary>Перечисление Режимов Отображения.</summary>
    public enum ViewModeEnum { Empty, View, Adding, Editing }

    /// <summary>Интерфейс списка Сотрудников с командами для его изменения.</summary>
    public interface IEmployeesList : ISelectedEmployee
    {
        /// <summary>Коллекция Cотрудников.</summary>
        ObservableCollection<IEmployeeVM> Employees { get; }

        /// <summary>Команда перехода в один из Pежим Отображения.</summary>
        RelayCommand<ViewModeEnum> ModeCommand { get; }

        /// <summary>Команда удаления Сотрудника.</summary>
        RelayCommand<IEmployeeVM> RemoveEmployeeCommand { get; }
    }
}
