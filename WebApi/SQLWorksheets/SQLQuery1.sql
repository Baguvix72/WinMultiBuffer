﻿select *
from BufferItems

select *
from Users

insert into Users (Username, Password)
values ('admin', 'admin');

delete from BufferItems
where id = 33