 -- BigDouble has arbitrary size, therefore text is used for numerical values that use BigDouble

CREATE TABLE player () {
	`id`				int PRIMARY KEY,
	`saveName`			varchar(255),
	`funds`				text,
	`humans`			text,
}

CREATE TABLE playerScavengers () {
	`playerId`			int,
	`scavengerId`		int,
	PRIMARY KEY(`playerId`, `scavengerId`)
}

CREATE TABLE scavengers (
	`id`				int PRIMARY KEY,
	`name`				varchar(255),
	`age`				text,
	`lifeSpan`			text,
	`efficiencyMulti`	text,
	`fundsPerGameTick`	text,
	`location`			point,
);