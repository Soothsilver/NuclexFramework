﻿#region CPL License
/*
Nuclex Framework
Copyright (C) 2002-2009 Nuclex Development Labs

This library is free software; you can redistribute it and/or
modify it under the terms of the IBM Common Public License as
published by the IBM Corporation; either version 1.0 of the
License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
IBM Common Public License for more details.

You should have received a copy of the IBM Common Public
License along with this library
*/
#endregion

#if UNITTEST

using System;
using System.Collections.Generic;
using System.Globalization;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using NUnit.Framework;

namespace Nuclex.Graphics.SpecialEffects.Resources {

  /// <summary>Unit tests for the debug drawer resources</summary>
  [TestFixture]
  public class UnitTestResourcesTest {

    /// <summary>Verifies that an instance of the resource class can be created</summary>
    [Test]
    public void TestResourceClassCreation() {
      UnitTestResources resources = new UnitTestResources();
      Assert.IsNotNull(resources); // nonsense; avoids compiler warning
    }

    /// <summary>Tests the 'Culture' property of the resource class</summary>
    [Test]
    public void TestAssignCulture() {
      UnitTestResources.Culture = CultureInfo.CurrentCulture;
      Assert.AreSame(CultureInfo.CurrentCulture, UnitTestResources.Culture);
    }

    /// <summary>Verifies that the water surface effect can be accessed</summary>
    [Test]
    public void TestWaterSurfaceEffect() {
      Assert.IsNotNull(UnitTestResources.WaterSurfaceEffect);
    }

  }

} // namespace Nuclex.Graphics.SpecialEffects.Resources

#endif // UNITTEST
