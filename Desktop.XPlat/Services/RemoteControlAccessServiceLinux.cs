﻿using Avalonia.Threading;
using Tess.Desktop.Core.Interfaces;
using Tess.Desktop.XPlat.ViewModels;
using Tess.Desktop.XPlat.Views;
using Tess.Shared.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tess.Desktop.XPlat.Services
{
    public class RemoteControlAccessServiceLinux : IRemoteControlAccessService
    {
        public async Task<bool> PromptForAccess(string requesterName, string organizationName)
        {
            return await Dispatcher.UIThread.InvokeAsync(async () =>
            {
                var promptWindow = new PromptForAccessWindow();
                var viewModel = promptWindow.DataContext as PromptForAccessWindowViewModel;
                if (!string.IsNullOrWhiteSpace(requesterName))
                {
                    viewModel.RequesterName = requesterName;
                }
                if (!string.IsNullOrWhiteSpace(organizationName))
                {
                    viewModel.OrganizationName = organizationName;
                }

                var isOpen = true;
                promptWindow.Closed += (sender, arg) =>
                {
                    isOpen = false;
                };
                promptWindow.Show();
                while (isOpen)
                {
                    await Task.Delay(100);
                }
   
                return viewModel.PromptResult;
            });
        }
    }
}
