﻿namespace DefaultInterfaceImplementation
{
	// Мы можем наследовать интерфейс с реализацией по умочанию обязательного определения метода интефрейса в теле класса
	// При этому данный метод не будет доступен из экзепляра класса.
	// Но вызвать реализацию интерфейса возможно, приведя экземляр класса к интерфейсному типу.
	public sealed class Pizzeria : IRestaurant
	{
	}
}
