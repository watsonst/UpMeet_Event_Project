import { Component, OnInit } from '@angular/core';
import { Favorites } from '../../models/Favorites';
import { FavoritesApiService } from '../../services/favorites-api.service';


@Component({
  selector: 'app-favorite-list',
  templateUrl: './favorite-list.component.html',
  styleUrls: ['./favorite-list.component.css']
})
export class FavoriteListComponent implements OnInit {

  favorites: Favorites[] = []

  constructor(
    private favoriteAPISvc: FavoritesApiService
  ) { }

  ngOnInit(): void {
    this.addDefaultFavorites();
  }

  addDefaultFavorites() {
    this.favoriteAPISvc.getFavorites().subscribe((favorites => {
      console.log("[INFO]")
      console.log(favorites);
      this.favorites = favorites
    }))

}
}