﻿namespace ModelGenApp.ViewModels;
    

public class LibraryConfigViewModel : VisibleViewModel
{

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.RecordNumber),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.RecordNumberTooltip)
    )]
  public int RecordNumber
  {
    [DebuggerStepThrough]
    get { return _RecordNumber; }
    set
    {
      if (_RecordNumber != value)
      {
        _RecordNumber = value;
        NotifyPropertyChanged(nameof(RecordNumber));
      }
    }
  }
  private int _RecordNumber;

  [DataGridColumn(
    //IsReadOnly = true,
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.LibraryName),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.LibraryNameTooltip)
    )]
  public string Name
  {
   [DebuggerStepThrough] get { return _Name; }
    set
    {
      if (_Name != value)
      {
        _Name = value;
        NotifyPropertyChanged(nameof(Name));
      }
    }
  }
  private string _Name = string.Empty;


  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.IsSourceLib),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.IsSourceLibTooltip),
    CheckImmediately = true,
    UpdateImmediately = true
    )]
  public bool IsSource
  {
   [DebuggerStepThrough] get { return _IsSource; }
    set
    {
      if (_IsSource != value)
      {
        _IsSource = value;
        NotifyPropertyChanged(nameof(IsSource));
        if (value)
          IsTarget = false;
      }
    }
  }
  private bool _IsSource;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.IsTargetLib),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.IsTargetLibTooltip),
    CheckImmediately = true,
    UpdateImmediately = true
    )]
  public bool IsTarget
  {
   [DebuggerStepThrough] get { return _IsTarget; }
    set
    {
      if (_IsTarget != value)
      {
        _IsTarget = value;
        NotifyPropertyChanged(nameof(IsTarget));
        if (value)
          IsSource = false;
      }
    }
  }
  private bool _IsTarget;


  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.IsUsedLib),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.IsUsedLibTooltip)
    )]
  public bool IsUsed
  {
   [DebuggerStepThrough] get { return _IsUsed; }
    set
    {
      if (_IsUsed != value)
      {
        _IsUsed = value;
        NotifyPropertyChanged(nameof(IsUsed));
        if (value)
          _IsUsed = false;
      }
    }
  }
  private bool _IsUsed;  
}
