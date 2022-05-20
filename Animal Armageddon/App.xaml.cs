using Animal_Armageddon.Logic;
using Animal_Armageddon.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Animal_Armageddon
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Ioc.Default.ConfigureServices(
                          new ServiceCollection()
                              .AddSingleton<IMainWindowLogic, MainWindowLogic>()
                              .AddSingleton<INewGameWindowLogic, NewGameWindowLogic>()
                              .AddSingleton<INewGameWindowService, NewGameWindowService>()                              
                              .AddSingleton<IMessenger>(WeakReferenceMessenger.Default)
                              .BuildServiceProvider()
                          );
        }

    }
}
