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

public class Mission
{

    //properties

	private int howmanydays
	{
		get;
		set;
	}

	private DateTime begniningDateEarth
	{
		get;
		set;
	}

	private List<String> l_genericActivity
	{
        //get general activity from XML
		get;
		set;
	}

	public virtual List<Day> l_day
	{
		get;
		set;
	}

	public virtual List<Astronaut> l_astronaut
	{
		get;
		set;
	}

	public virtual List<Place> l_place
	{
		get;
		set;
	}

    //constructor

    public Mission(int Howmanydays, DateTime BeginningDateEatrh, List<Astronaut> L_astronaut)
	{
        howmanydays = Howmanydays;
        begniningDateEarth = BeginningDateEatrh;
        l_astronaut = L_astronaut;
        l_day = new List<Day>();
        for (int i=0 ; i <= howmanydays; i++) {Past Day = new Past(i);}
        //generate l_activity from XML
	}

    //methodes

    public void add_astronaut(Astronaut astro) {l_astronaut.Add(astro);}

    public void rm_astronaut(Astronaut astro) {if (l_astronaut.Contains(astro)) l_astronaut.Remove(astro);}

	public virtual Day getDay(int numDay) {if (numDay<=howmanydays) {return l_day[numDay];} return null;} 

	public virtual List<Place> getPlaces(Day start, Day end)
	{
        List<Place> lp = new List<Place>();
		for (int i = start.Number; i <=end.Number; i++)
        {
            /* (l_day[i].l_activity.Place!=
            {

            }*/

        }
        return lp;
	}

	public virtual void beginMission(DateTime CurrentEarthDate)
	{
		throw new System.NotImplementedException();
	}

	public virtual void modifyStatus(Status newStatus)
	{
		throw new System.NotImplementedException();
	}

	public virtual list<> getListActivity()
	{
		throw new System.NotImplementedException();
	}

}
