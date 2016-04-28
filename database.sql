CREATE DATABASE Questions
GO
USE Questions
CREATE TABLE Questions (id int IDENTITY(1,1), Text nvarchar(255), Answer1 nvarchar(200), Answer2 nvarchar(200), Answer3 nvarchar(200),
						Answer4 nvarchar(200) PRIMARY KEY(id))
GO
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Как называется место на берегу, где обитают тюлени?', 'Лежбище', 'Стойбище', 'Пастбище', 'Гульбище');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Как мировая пресса называла премьер-министра Великобритании Маргарет Тэтчер?', 'Железная леди', 'Стальная леди', 'Оловянный солдатик', 'Крепкий орешек');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Какой из этих городов южнее остальных?', 'Каир', 'Токио', 'Мадрид', 'Сан-Франциско');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Через какой город мира проходит нулевой меридиан?', 'Гринвич', 'Гринсборо', 'Глазко', 'Гронинген');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Какая птица является символом Новой Зеландии?', 'Киви','Жако','Эму','Казуар');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Какого короля англичане прозвали "Львиное сердце"?','Ричард I', 'Вильгельм I', 'Георг I', 'Генрих I');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Как в народе называются финансовые институты, обещающие вкладчикам золотые горы?', 'Пирамиды', 'Гробницы', 'Захоронения', 'Сфинксы');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Какая награда вручается вместе с присвоением звания Героя России?', 'Медаль "Золотая звезда"', 'Медаль "за отвагу"', 'Орден Суворова', 'Орден мужества');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('В каком городе родился Вольфганг Амадей Моцарт?', 'Зальцбург', 'Веймар', 'Прага', 'Вена');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Какую реку Юлий Цезарь перешел со словами "Жребий брошен"?', 'Рубикон', 'Припять','Нил','Евфрат');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Как называется искусство аранжировки цветов?', 'Икебана', 'Суши','Кэндо', 'Харакири');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Какая страна является мировым лидером по производству кофе?', 'Бразилия', 'Венесуэла', 'Мексика', 'Аргентина');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Что труднее всего дается не трезвому человеку?', 'Вязать лыко', 'Трепать нервы', 'Бить баклуши','Витать в облаках');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Как называют японских мафиози?', 'Якудза', 'Джакузи', 'Камикадзе', 'Коза Ностра');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Участник какого из перечисленных спортивных состязаний экипирован винтовкой?', 'Биатлон', 'Бейсбол', 'Бадминтон', 'Бобслей');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('В каком канадском городе находится самая высокая в мире телебашня?', 'Торонто', 'Оттава', 'Ванкувер', 'Монреаль');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Какой из этих романов написал не Хемингуэй?', '"Триумфальная арка"', '"Фиеста"', '"По ком звонит колокол"', '"Острова в океане"');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('В каком виде спорта прославился Евгений Кафельников?', 'Теннис', 'Бокс','Метание ядра','Охота на лис');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Как называется пара, присутствующая на церемонии бракосочетания вместе с молодыми?', 'Свидетели', 'Соучастники', 'Запасные', 'Защитники');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Как звали невесту Эдмона Дантеса, будущего графа Монте-Кристо?', 'Мерседес', 'Тойота', 'Хонда','Лада');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Какой цвет получается при смешении синего и красного?', 'Фиолетовый', 'Коричневый', 'Зеленый', 'Голубой');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Какая компания в Италии выпускает наибольшее количество автомобилей?', 'Фиат', 'Феррари', 'Ламборгини', 'Альфа Ромео');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Кто из древних философов, по преданию, жил в бочке?', 'Диоген', 'Демокрит', 'Платон', 'Сократ');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Каким из этих природных явлений А.Островский назвал свою пьесу?', 'Гроза', 'Снегопад', 'Шаровая молния', 'Гололед');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Какой туман кажется В.Добрынину похожим на обман в одной из его песен?', 'Синий', 'Утренний', 'Сиреневый', 'Желтый');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Кому принадлежат строки - пророчества: "Настанет год, России черный год, Когда царей корона упадет..."?', 'Лермонтов', 'Пушкин','Нострадамус','Некрасов');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Как называется маскировочная окраска военной техники и обмундирования?', 'Камуфляж','Макияж','Хаки','Камуфлет');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Какой материк омывается всеми четырьмя океанами?', 'Евразия', 'Северная Америка', 'Австралия', 'Южная Америка');
INSERT INTO Questions(Text, Answer1, Answer2, Answer3, Answer4) VALUES('Какие машины предпочитал угонять Юрий Деточкин?', 'Волга', 'Победа', 'Иномарки', 'Жигули');