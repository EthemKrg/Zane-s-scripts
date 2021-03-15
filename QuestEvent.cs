﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class QuestEvent 
{
    public enum EventStatus { WAITING, CURRENT, DONE}
    //waiting tamamlanmamış alınmayı bekliyor
    // current görev alınmış ve üzerine oynanıyor
    //done görev tamamlanmış

    public string name;
    public string description;
    public string id;
    public int order = -1;
    public EventStatus status;
    public QuestButton button;
    public GameObject location;

    public List<QuestPath> pathlist = new List<QuestPath>();

    public QuestEvent(string n, string d, GameObject loc)
    {
        id = Guid.NewGuid().ToString();
        name = n;
        description = d;
        status = EventStatus.WAITING;
        location = loc;
    }

    public void UpdateQuestEvent(EventStatus es)
    {
        status = es;
        button.UpdateButton(es);
    }

    public string GetId()
    {
        return id;
    }
    
}
