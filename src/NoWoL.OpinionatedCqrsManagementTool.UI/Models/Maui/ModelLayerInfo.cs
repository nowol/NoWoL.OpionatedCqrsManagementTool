﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace NoWoL.OpinionatedCqrsManagementTool.UI.Models.Maui
{
    public partial class ModelLayerInfo : ObservableValidator
    {
        [ObservableProperty]
        private bool _generate;

        [ObservableProperty]
        private string? _namespace;

        [ObservableProperty]
        private string? _overriddenName;

        [ObservableProperty]
        private ModelInfo? _inheritsFrom;

        [ObservableProperty]
        private ModelInfo? _inheritsGeneric;

        [ObservableProperty]
        private string? _converter;
    }
}