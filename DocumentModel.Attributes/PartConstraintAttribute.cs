using System;

namespace DocumentModel.Attributes
{
  [AttributeUsage(AttributeTargets.Class |AttributeTargets.Interface, AllowMultiple = true)]
  public sealed class PartConstraintAttribute : Attribute, IConstraintAttribute
  {
    public PartConstraintAttribute(Type constraintType, bool minOccursIsNonZero, bool maxOccursGreatThanOne)
    {
      ConstraintType = constraintType;
      MinOccursIsNonZero = minOccursIsNonZero;
      MaxOccursGreatThanOne = maxOccursGreatThanOne;
    }

    public Type ConstraintType { get; }

    public bool MinOccursIsNonZero { get; }

    public bool MaxOccursGreatThanOne { get; }
  }
}