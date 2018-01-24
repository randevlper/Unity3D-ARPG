﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITriggerable
{
	bool Trigger();
}

public interface IDamageable
{
	bool Damage(float damage);
}