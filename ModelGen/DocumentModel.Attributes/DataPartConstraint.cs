using System;


#nullable enable
namespace DocumentModel.Attributes
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
  public sealed class DataPartConstraintAttribute : Attribute, IConstraintAttribute
  {
    public DataPartConstraintAttribute(
      Type constraintType,
      bool minOccursIsNonZero,
      bool maxOccursGreatThanOne)
    {
      this.ConstraintType = constraintType;
      this.MinOccursIsNonZero = minOccursIsNonZero;
      this.MaxOccursGreatThanOne = maxOccursGreatThanOne;
    }

    public Type ConstraintType { get; }

    public bool MinOccursIsNonZero { get; }

    public bool MaxOccursGreatThanOne { get; }
  }
}