﻿using Common;
using Staffing.DTO;
using System.Collections.ObjectModel;

namespace Staffing.InterfacesVM
{
    /// <summary>Интерфейс добавления нового Сотрудника.</summary>
    public interface IAddEmployee : IModeExitCommand
    {
        /// <summary>Коллекция должностей.</summary>
        ObservableCollection<PositionDto> Positions { get; }

        /// <summary>Данные добавляемого Сотрудника.</summary>
        IEmployeeVM AddEmployee { get; }

        /// <summary>Команда добавления Сотрудника.</summary>
        RelayCommand<IEmployeeVM> AddEmployeeCommand { get; }

    }
}
