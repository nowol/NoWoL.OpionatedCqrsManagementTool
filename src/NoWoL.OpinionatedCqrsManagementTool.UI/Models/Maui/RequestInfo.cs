﻿using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace NoWoL.OpinionatedCqrsManagementTool.UI.Models.Maui
{
    public partial class RequestInfo : ObservableValidator, IHasName
    {
        [ObservableProperty]
        private string? _name;

        [ObservableProperty]
        private string? _url;

        [ObservableProperty]
        private string? _verb;

        [ObservableProperty]
        private bool _allowAnonymous;

        [ObservableProperty]
        private string? _claims;

        [ObservableProperty]
        private RequestLayerInfo _domain = new();

        [ObservableProperty]
        private RequestLayerInfo _service = new();

        [ObservableProperty]
        private ObservableCollection<RequestPropertyInfo> _properties = new();

        [ObservableProperty]
        private ObservableCollection<RequestReturnCode> _returnCodes = new();
    }

    public partial class RequestReturnCode : ObservableValidator
    {
        [ObservableProperty]
        private int _statusCode;

        [ObservableProperty]
        private ModelInfo? _returns;
    }
}