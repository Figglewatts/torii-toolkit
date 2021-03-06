﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Torii.Binding.Attributes;
using UnityEngine;

namespace Torii.Binding
{
    public class ModelTest : MonoBehaviour, IPropertyWatcher
    {
        private float _aFloat;

        public float AFloat
        {
            get { return _aFloat; }
            set
            {
                _aFloat = value;
                NotifyPropertyChange(nameof(AFloat));
            }
        }

        public event Action<string, IPropertyWatcher> OnPropertyChange;

        public Guid GUID { get; private set; }

        public void NotifyPropertyChange(string propertyName)
        {
            OnPropertyChange?.Invoke(propertyName, this);
        }

        void Awake()
        {
            GUID = Guid.NewGuid();
        }
    }
}
