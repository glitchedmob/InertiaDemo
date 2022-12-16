import { Link } from '@inertiajs/inertia-react'

export const Navigation = () => {
    return (
        <header>
            <Link href="/">Home</Link>
            <br/>
            <Link href="/about">About</Link>
        </header>
    );    
}
