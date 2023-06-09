﻿using System.Xml;

XmlDocument document = new();
document.Load(@"D:\myusers.xml");

XmlElement? root = document.DocumentElement;

XmlNodeList nodes = root?.SelectNodes("//User//Name")!;
foreach (XmlNode node in nodes)
{
    Console.WriteLine(node.InnerText);
}

/*
Выбор узлов
Чтобы выбрать узлы в XML документе, XPath использует выражения пути. Узел выбирается следуя по заданному пути. Наиболее полезные выражения пути:

Выражение	Результат
имя_узла	Выбирает все узлы с именем "имя_узла"
/	Выбирает от корневого узла
//	Выбирает узлы от текущего узла, соответствующего выбору, независимо от их местонахождения
.	Выбирает текущий узел
..	Выбирает родителя текущего узла
@	Выбирает атрибуты
В следующей таблице приводятся некоторые выражения XPath, позволяющие сделать некоторые выборки по демонстрационному XML документу:

Выражение XPath	Результат
messages	Выбирает все узлы с именем "messages"
/messages	Выбирает корневой элемент сообщений
Примечание: Если путь начинается с косой черты ( / ), то он всегда представляет абсолютный путь к элементу!
messages/note	Выбирает все элементы note, являющиеся потомками элемента messages
//note	Выбирает все элементы note независимо от того, где в документе они находятся
messages//note	Выбирает все элементы note, являющиеся потомками элемента messages независимо от того, где они находятся от элемента messages
//@date	Выбирает все атрибуты с именем date
Предикаты
Предикаты позволяют найти конкретный узел или узел с конкретным значением.

Предикаты всегда заключаются в квадратные скобки.

В следующей таблице приводятся некоторые выражения XPath с предикатами, позволяющие сделать выборки по демонстрационному XML документу:

Выражение XPath	Результат
/messages/note[1]	Выбирает первый элемент note, который является прямым потомком элемента messages.
Примечание: В IE 5,6,7,8,9 первым узлом будет [0], однако согласно W3C это должен быть [1]. Чтобы решить эту проблему в IE, нужно установить опцию SelectionLanguage в значение XPath.
В JavaScript: xml.setProperty("SelectionLanguage","XPath");
/messages/note[last()]	Выбирает последний элемент note, который является прямым потомком элемента messages.
/messages/note[last()-1]	Выбирает предпоследний элемент note, который является прямым потомком элемента messages.
/messages/note[position()<3]	Выбирает первые два элемента note, которые являются прямыми потомками элемента messages.
//heading[@date]	Выбирает все элементы heading, у которых есть атрибут date
//heading[@date="10/01/2008"]	Выбирает все элементы heading, у которых есть атрибут date со значением "10/01/2008"
Выбор неизвестных заранее узлов
Чтобы найти неизвестные заранее узлы XML документа, XPath позволяет использовать специальные символы.

Спецсимвол	Описание
*	Соответствует любому узлу элемента
@*	Соответствует любому узлу атрибута
node()	Соответствует любому узлу любого типа
В следующей таблице приводятся некоторые выражения XPath со спецсимволами, позволяющие сделать выборки по демонстрационному XML документу:

Выражение XPath	Результат
/messages/*	Выбирает все элементы, которые являются прямыми потомками элемента messages
//*	Выбирает все элементы в документе
//heading[@*]	Выбирает все элементы heading, у которых есть по крайней мере один атрибут любого типа
Выбор нескольких путей
Использование оператора | в выражении XPath позволяет делать выбор по нескольким путям.

В следующей таблице приводятся некоторые выражения XPath, позволяющие сделать выборки по демонстрационному XML документу:

Выражение XPath	Результат
//note/heading | //note/body	Выбирает все элементы heading И body из всех элементов note
//heading | //body	Выбирает все элементы heading И body во всем документе

*/