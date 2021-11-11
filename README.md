# SortingPatients
Этот проект осуществляет поиск пациентов по разным критериям.

В нём применила следующие популярные подходы: Паттерн репозиторий, Инверсия зависимостей, Onion архитектура.

Слой Бизнес Логики оперирует сущностями, он не зависит от способа хранения данных. Для этого реализован паттерн репозиторий.

Репозиторий - хранилище, к которому обращется слой Бизнес Логики. Это хранилище оперирует сущностями, с которыми удобно работать самой Бизнес Логики.
Именно поэтму сами сущности(Models) и сам интерфейс репозитория(IPatientRepository) находится в его же слое(БЛ).

Так же частично реализована Onion-архитектура. Пользовательская часть должна зависеть только от БЛ,
но так как точка входа находится(в данном случае она может быть только одна) в пользовательском слое проводится инъекция зависимостей,
вследствие чего пользовательская часть начинает зависеть и от слоя DAL.
