﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Place
{
	private Double x
	{
		get;
		set;
	}

	private Double y
	{
		get;
		set;
	}

	private string name
	{
		get;
		set;
	}

	public virtual IEnumerable<Outside> l_outside
	{
		get;
		set;
	}

	public Place(int pixel_x, int pixel_y, string name)
	{
	}

	public Place(Double x, Double y, string name)
	{
	}

}
